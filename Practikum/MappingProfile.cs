using AutoMapper;
using Common.DTO_s;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<User, UserDTO>().ReverseMap();
            
        }
    }
}
