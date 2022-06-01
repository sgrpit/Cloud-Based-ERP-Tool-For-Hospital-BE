using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.MappingProfile
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<Department, DepartmentReqDto>().ReverseMap();
                config.CreateMap<DepartmentResDto, Department>().ReverseMap();                
            });

            return mappingConfig;
        }
    }
}
