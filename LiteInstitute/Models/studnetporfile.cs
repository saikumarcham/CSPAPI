using AutoMapper;
using LiteInstitute.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiteInstitute.Models
{
    public class studnetporfile : Profile
    {
        public studnetporfile()
        {
            CreateMap<Student, StudentTd>()
           .ForMember(d => d.StudentAddressTds, opt => opt.Ignore());

           CreateMap<StudentTd, Student>();
        }
  
    }
}
