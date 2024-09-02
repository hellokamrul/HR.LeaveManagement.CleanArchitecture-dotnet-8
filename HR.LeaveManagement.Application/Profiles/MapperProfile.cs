using AutoMapper;
using HR.LeaveManagement.Application.DTOs.LeaveAllocation;
using HR.LeaveManagement.Application.DTOs.LeaveRequest;
using HR.LeaveManagement.Application.DTOs.LeaveType;
using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Profiles
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            CreateMap<LeaveRequest,LeaveRequestDto>().ReverseMap(); 
            CreateMap<LeaveAllocation,LeaveAllocationDto>().ReverseMap();   
            CreateMap<LeaveType,LeaveTypeDto>().ReverseMap();   
        }
    }
}
