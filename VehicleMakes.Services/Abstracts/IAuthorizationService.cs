﻿using VehicleMakes.Data.Entities.Identity;
using VehicleMakes.Data.Requests;
using VehicleMakes.Data.Results;

namespace VehicleMakes.Service.Abstracts
{
    public interface IAuthorizationService
    {
        public Task<string> AddRoleAsync(string roleName);
        public Task<bool> IsRoleExistByName(string roleName);
        public Task<string> EditRoleAsync(EditRoleRequest request);
        public Task<string> DeleteRoleAsync(int roleId);
        public Task<bool> IsRoleExistById(int roleId);
        public Task<List<Role>> GetRolesList();
        public Task<Role> GetRoleById(int id);
        public Task<ManageUserRolesResult> ManageUserRolesData(User user);
        public Task<string> UpdateUserRoles(UpdateUserRolesRequest request);
        public Task<ManageUserClaimsResult> ManageUserClaimData(User user);
        public Task<string> UpdateUserClaims(UpdateUserClaimsRequest request);
    }
}
