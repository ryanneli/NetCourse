using API.Domain.Entities;
using API.Domain.Interfaces;
using API.Application.Interfaces;
using API.Application.DTO;
namespace API.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUser _userRepository;

        public UserService(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserGetDto> GetByIdAsync(int id)
        {
            var user = await _userRepository.GetByIdAsync(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            return new UserGetDto
            {
                Id = user.Id,
                Name = user.Name,
                Profile = user.Profile,
                Excluido = user.Excluido
            };
        }

        public async Task<List<UserGetDto>> GetAllAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return users.Select(user => new UserGetDto
            {
                Id = user.Id,
                Name = user.Name,
                Profile = user.Profile,
                Excluido = user.Excluido
            }).ToList();
        }

        public async Task<UserGetDto> AddAsync(UserPutDto userDto)
        {
            using var hmac = new System.Security.Cryptography.HMACSHA512();
            byte[] passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(userDto.Password));
            byte[] passwordSalt = hmac.Key;


            var user = new User
            {
                Name = userDto.Name,
                Profile = userDto.Profile,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
            };
            var addedUser = await _userRepository.AddAsync(user);
            return new UserGetDto
            {
                Id = addedUser.Id,
                Name = addedUser.Name,
                Profile = addedUser.Profile,
                Excluido = addedUser.Excluido
            };
        }

        public async Task<UserGetDto> UpdateAsync(int id, UserPutDto userDto)
        {
            var existingUser = await _userRepository.GetByIdAsync(id);
            if (existingUser == null)
            {
                throw new Exception("User not found");
            }

            if (!string.IsNullOrEmpty(userDto.Password))
            {

                existingUser.PasswordHash = userDto.Password;
                existingUser.Name = userDto.Name;
                existingUser.Profile = userDto.Profile;

            }
            var updatedUser = await _userRepository.UpdateAsync(existingUser);

            return new UserGetDto
            {
                Id = updatedUser.Id,
                Name = updatedUser.Name,
                Profile = updatedUser.Profile,
                Excluido = updatedUser.Excluido
            };
        }
    }
}
