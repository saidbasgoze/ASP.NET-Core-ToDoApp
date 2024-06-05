using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNTier.Business.Mappings.AutoMapper
{
    public class WorkProfile : Profile
    {
        public WorkProfile() { 
            CreateMap<Work,WorkListDto>().ReverseMap();
            CreateMap<Work, WorCreatetDto>().ReverseMap();
            CreateMap<Work, WorUpdatetDto>().ReverseMap();
            CreateMap<WorkListDto, WorUpdatetDto>().ReverseMap();
        }
    }
}
