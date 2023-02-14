using AutoMapper;
using Common.DTO_s;
using Repositories.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities
{
     
    public class UserService : IService<UserDTO>
    {
        private readonly IMapper _mapper;
        private readonly IUser<User> _userRepository;
        private static int FamilyCode = 1;

        public UserService(IMapper mapper, IUser<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Add(UserDTO entity)
        {
            var users =await GetAll();
            var isExist = users.FirstOrDefault(x => x.TZ == entity.TZ);
            if (isExist != null)
                return null;
            var res = users.FirstOrDefault(x => x.GetTz == entity.GetTz);
            if (res == null)
                entity.FamilyId = FamilyCode++;
            else
                entity.FamilyId = res.FamilyId;
            return _mapper.Map<UserDTO>(await _userRepository.AddAsync(_mapper.Map<User>(entity)));

        }

        public async Task<List<UserDTO>> GetAll()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAllAsync());
        }

        public async Task<UserDTO> GetById(int id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetByIdAsync(id));
        }
    }
}
