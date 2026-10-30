using API.Application.DTO;
using API.Application.Interfaces;
using API.Domain.Interfaces;
using API.Domain.Entities;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;
using Microsoft.Win32;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace API.Application.Services
{

    public class RegistrationService : IRegistrationService {
        private readonly IRegistration _registration;

        public RegistrationService(IRegistration regitro)
        {
            _registration = regitro;
        }

        public async Task<RegistrationGetDto> AddAsync(RegistrationPutDto registro)
        {
            var newRegistro = await _registration.AddAsync(new Registration { UserId = registro.UserId, GroupId = registro.GroupId, RegistrationDate = registro.RegistrationDate, IsActive = registro.IsActive });
            if (newRegistro == null) return null;

            return new RegistrationGetDto
            {
            
                UserId = newRegistro.UserId,
                GroupId = newRegistro.GroupId,
                RegistrationDate = newRegistro.RegistrationDate,
                IsActive = newRegistro.IsActive
            };


        }

        public async Task<RegistrationGetDto> DeleteAsync(int id)
        {
            var deleted = await _registration.DeleteAsync(id);
            if (deleted == null) return null;

            return new RegistrationGetDto
            {
                Id = deleted.Id,
                UserId = deleted.UserId,
                GroupId = deleted.GroupId,
                RegistrationDate = deleted.RegistrationDate,
                IsActive = deleted.IsActive
            };
        }


        public async Task<RegistrationGetDto> GetByIdAsync(int id)
        {
            var selectedItem = await _registration.GetByIdAsync(id);
            if (selectedItem == null) return null;

           return new RegistrationGetDto
            {
                Id = selectedItem.Id,
                RegistrationDate = selectedItem.RegistrationDate,
                IsActive = selectedItem.IsActive,

                User = new UserGetDto
                {
                    Id = selectedItem.User.Id,
                    Name = selectedItem.User.Name,
                    Profile = selectedItem.User.Profile,
                    Excluido = selectedItem.User.Excluido,
                },

                Group = new GroupGetDto
                {
                    Id = selectedItem.Group.Id,
                    Name = selectedItem.Group.Name,
                    Description = selectedItem.Group.Description
                }
            };
        }

        public async Task<List<RegistrationGetDto>> GetAllAsync()
        {
            var registrations = await _registration.GetAllAsync();
            var ListRegistrations = new List<RegistrationGetDto>();

            ListRegistrations = registrations.Select(item => new RegistrationGetDto
            {
                Id = item.Id,
                UserId = item.UserId,
                GroupId = item.GroupId,
                RegistrationDate = item.RegistrationDate,
                IsActive = item.IsActive,
                User = new UserGetDto
                {
                    Excluido = item.User.Excluido,
                    Id = item.User.Id,
                    Name = item.User.Name,
                    Profile = item.User.Profile
                },
                Group = new GroupGetDto
                {
                    Excluido = item.Group.Excluido,
                    Id = item.Group.Id,
                    Name = item.Group.Name,
                    Description = item.Group.Description
                }

            }).ToList();

        
            return ListRegistrations;
        }

        public async Task<RegistrationGetDto> UpdateAsync(int id, RegistrationPutDto newregistro)
        {
            var OldItem = await _registration.GetByIdAsync(id);
            OldItem.UserId = newregistro.UserId;
            OldItem.GroupId = newregistro.GroupId;
            OldItem.RegistrationDate = newregistro.RegistrationDate;
            OldItem.IsActive = newregistro.IsActive;

            if (OldItem == null) return null;

            await _registration.UpdateAsync(OldItem);

            return new RegistrationGetDto
            {
                Id = OldItem.Id,
                UserId = OldItem.UserId,
                GroupId = OldItem.GroupId,
                RegistrationDate = OldItem.RegistrationDate,
                IsActive = OldItem.IsActive
            };

        }

        

    
    }   
    
    }