using GarmentStoreAPI.UserModels;

namespace GarmentStoreAPI.IService
{
    public interface IUserService
    {
        ResponseModel Login(LoginDTO user);
    }
}
