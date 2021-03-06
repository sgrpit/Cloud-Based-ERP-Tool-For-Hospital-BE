using AutoMapper;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Domain;
using Cloud_Based_ERP_Tool_For_Hospital_BE.DTOs;
using Cloud_Based_ERP_Tool_For_Hospital_BE.Repo.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Repo
{
    public class StaffRepo : IStaffRepo
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IDepartmentRepo _departmentRepo;
        public StaffRepo(ApplicationDbContext dbContext, IMapper mapper, IDepartmentRepo departmentRepo)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _departmentRepo = departmentRepo;
        }

        public async Task<StaffDetailsResDto> CreateStaff(CreateStaffReqDto createStaffReqDto, string staffId)
        {
            try
            {
                var staff = _mapper.Map<Staffs>(createStaffReqDto);
                staff.StaffId = staffId;
                staff.CreatedBy = "Admin";
                staff.CreatedOn = DateTime.Now;
                staff.ModifiedBy = "Admin";
                staff.ModifiedOn = DateTime.Now;
                _dbContext.Staffs.Add(staff);
                await _dbContext.SaveChangesAsync();
                var newStaff = await _dbContext.Staffs.OrderBy(s => s.Id).LastOrDefaultAsync();
                string userName = CreateUserName(staff.FirstName + "." + staff.LastName);
                var loginDetails = new LoginDetails
                {
                    UserName = userName.Trim(),
                    UserPassword = userName + "@" + staff.MobileNo.Substring(1, 3),
                    StaffId = newStaff.Id
                    
                };
                _dbContext.LoginDetails.Add(loginDetails);
                await _dbContext.SaveChangesAsync();

                return _mapper.Map<StaffDetailsResDto>(newStaff);
            }
            catch (Exception ex)
            {
                if (ex.InnerException.Message.Contains("MobileNo"))
                {
                    throw new Exception("Mobile No already exists");
                }
                else if (ex.InnerException.Message.Contains("EmailId"))
                {
                    throw new Exception("Email Id already exists");
                }
                else
                {
                    throw new Exception(ex.InnerException.Message);
                }
            }
        }

        private bool CheckIfUserNameAlreadyExists(string userName)
        {
            var alreadyExist = _dbContext.LoginDetails.FirstOrDefault(l => l.UserName == userName);
            if (alreadyExist != null)
                return true;
            else
                return false;
        }

        private string CreateUserName(string userName)
        {
            int i = 0;
            bool alreadyExist = CheckIfUserNameAlreadyExists(userName);
            if (alreadyExist)
            {
                i++;
                 CreateUserName(userName + Convert.ToString(i));
            }
            else
                return userName;
            return string.Empty;
        }

        public async Task<bool> DeleteStaffDetails(int id)
        {
            try
            {
                var staffDetailsToDelete = await _dbContext.Staffs.FirstOrDefaultAsync(d => d.Id == id);
                _dbContext.Staffs.Remove(staffDetailsToDelete);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                
            }
        }

        public async Task<IEnumerable<StaffDetailsResDto>> GetAllStaffDetails()
        {
            var  staffList = await _dbContext.Staffs.ToListAsync();
            return _mapper.Map<IEnumerable<StaffDetailsResDto>>(staffList);
        }

        public async Task<string> GetLatestStaffId()
        {
            Staffs staff = await _dbContext.Staffs.OrderByDescending(s => s.StaffId).FirstOrDefaultAsync();
            if (staff == null)
                return string.Empty;
            else
                return staff.StaffId;
        }

        public async Task<IEnumerable<StaffDetailsResDto>> GetStaffDetailsByFilter(string staffId, string contactNo, int deparmanentId = 0)
        {
            if(deparmanentId != 0)
            {
                var staff = await _dbContext.Staffs.Where(s => s.DepartmentsId == deparmanentId && s.UserRoleId == 2).ToListAsync();
                return _mapper.Map<IEnumerable<StaffDetailsResDto>>(staff);
            }
            throw new NotImplementedException();
        }

        private async Task<Staffs> GetStaffDetailsById(int id)
        {
            return await _dbContext.Staffs.FirstOrDefaultAsync(s => s.Id == id);
            
        }

        public Task<IEnumerable<StaffDetailsResDto>> GetStaffDetailsByPatientUHID(string staffId, string ContactNo)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StaffDetailsResDto>> GetStaffDetailsByRole(int roleId)
        {
            var staff = await _dbContext.Staffs.Where(s => s.UserRoleId == roleId).ToListAsync();
            return _mapper.Map<IEnumerable<StaffDetailsResDto>>(staff);
            //throw new NotImplementedException();
        }

        public async Task<StaffDetailsResDto> UpdateStaffDetails(UpdateStaffReqDto updateStaffReqDto)
        {
            var staff = await GetStaffDetailsById(updateStaffReqDto.Id);
            staff.FirstName = updateStaffReqDto.FirstName;
            staff.LastName = updateStaffReqDto.LastName;
            staff.MiddleName = updateStaffReqDto.MiddleName;
            staff.MobileNo = updateStaffReqDto.MobileNo;
            staff.EmailId = updateStaffReqDto.EmailId;
            staff.Gender = updateStaffReqDto.Gender;
            staff.City = updateStaffReqDto.City;
            staff.ZipCode = updateStaffReqDto.ZipCode;
            staff.DateOfBirth = updateStaffReqDto.DateOfBirth;
            staff.JoiningDate = updateStaffReqDto.JoiningDate;
            staff.DepartmentsId = updateStaffReqDto.DepartmentsId;
            staff.ModifiedBy = "Admin";
            staff.ModifiedOn = DateTime.Now;
            _dbContext.Staffs.Update(staff);
            await _dbContext.SaveChangesAsync();
            return _mapper.Map<StaffDetailsResDto>(staff);

        }

        public async Task<StaffDetailsResDto> GetStaffsDetailsById(int id)
        {
            var staff = await _dbContext.Staffs.FirstOrDefaultAsync(s => s.Id == id);
            return _mapper.Map<StaffDetailsResDto>(staff);
        }
    }
}
