﻿namespace CarShop.Service.Data.User
{
    using CarShop.Models.Pagination;
    using CarShop.Models.Request.User;
    using CarShop.Models.Response;
    using CarShop.Models.Response.User;
    using CarShop.Service.Common.Extensions.Pager;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IUserService
    {
        public Task<InfoResponse> BlockAsync(long userId);
        public Task<InfoResponse> DeleteAsync(long id);
        public Task<Response<Paginate<UserResponseModel>>> GetAllAsync(PaginationRequestModel requestModel);
        public Task<Response<UserResponseModel>> GetByIdAsync(long id);
        public Task<long> GetCountAsync();
        public Task<InfoResponse> RegisterRoleAsync(long userId, long roleId);
        public Task<InfoResponse> RemoveRoleAsync(long userId, long roleId);
        public Task<Response<Paginate<UserResponseModel>>> FilterByAsync(UserFilterAndSortRequestModel requestModel);
        public Task<Response<Paginate<UserResponseModel>>> SortByAsync(UserSortRequestModel requestModel, IQueryable<CarShop.Models.Base.User> query = null);
        public Task<InfoResponse> UnblockAsync(long userId);
    }
}