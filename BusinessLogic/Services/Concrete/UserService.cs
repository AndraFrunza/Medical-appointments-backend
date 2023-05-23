using BusinessLogic.Dtos;
using BusinessLogic.Helpers;
using BusinessLogic.Mapper;
using BusinessLogic.Services.Interfaces;
using Database.Entities;
using Database.Repositories.Abstract;
using Database.Repositories.Concrete;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace BusinessLogic.Services
{

    public class UserService : IUserService
    {

        private readonly IUserRepository userRepository;
        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings, IUserRepository userRepository)
        {
            _appSettings = appSettings.Value;
            this.userRepository = userRepository;
        }

        public AuthenticateResponseDto Authenticate(AuthenticateRequestDto model)
        {
            var user = userRepository.GetByEmail(model.Email);

            // return null if user not found
            if (user == null) return null;

            var userDto = UserMapper.ToDto(user);

            // authentication successful so generate jwt token
            var token = generateJwtToken(userDto);

            return new AuthenticateResponseDto
            {
                User = userDto,
                Token = token,
            };
        }

        public IEnumerable<UserEntity> GetAll()
        {
            
            return userRepository.GetAll();
        }

        public UserDto GetById(int id)
        {
            var user = userRepository.GetById(id);
            return UserMapper.ToDto(user);
        }

        // helper methods

        private string generateJwtToken(UserDto user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()), new Claim("role", user.Role.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }





    }
}

