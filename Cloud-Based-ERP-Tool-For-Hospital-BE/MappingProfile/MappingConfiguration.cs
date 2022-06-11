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
                config.CreateMap<Staffs, CreateStaffReqDto>().ReverseMap();
                config.CreateMap<StaffDetailsResDto, Staffs>().ReverseMap();
                config.CreateMap<Staffs, UpdateStaffReqDto>().ReverseMap();
                config.CreateMap<PatientAppointment, PatientAppoinmentReqDto>().ReverseMap();
                config.CreateMap<PatientAppoinmentResDto, PatientAppointment>().ReverseMap();
                config.CreateMap<UserRoleResDto, UserRole>().ReverseMap();
                config.CreateMap<Patients, PatientReqDto>().ReverseMap();
                config.CreateMap<PatientResDto, Patients>().ReverseMap();
                config.CreateMap<PatientPresciptionReqDto, PatientPrescriptionHistory>().ReverseMap();
                    //.ForPath(dest => dest.Patient.Id, s => s.MapFrom(src => src.PatientId));
                config.CreateMap<PatientPrescriptionResDto, PatientPrescriptionHistory>().ReverseMap();

                //config.CreateMap<PatientAppoinmentReqDto, InPatientDirectory>()
                //    .ForPath(dest => dest.Staff.Id, act => act.MapFrom(src => src.StaffId)).ReverseMap();

                config.CreateMap<InPatientDirectory, PatientAdmissionReqDto>().ReverseMap();
                config.CreateMap<InPatientDirectory, PatientAdmissionResDto>().ReverseMap();

            });

            return mappingConfig;
        }
    }
}
