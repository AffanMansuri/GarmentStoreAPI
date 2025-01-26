using GarmentStoreAPI.IService;
using GarmentStoreAPI.UserModels;
using System.Net;

namespace GarmentStoreAPI.Service
{
    public class UserService : IUserService
    {
        private readonly static List<UserModel> users = new()
        {
            new(){ Username = "affan", Password = "123", Role = Roles.User},
            new(){ Username = "saif", Password = "123", Role = Roles.Admin}
        };

        private ResponseModel objResponse = new ResponseModel();
        public ResponseModel Login(LoginDTO user)
        {
            var result = users.FirstOrDefault(usr => usr.Username == user.Username && usr.Password == user.Password);
            if(result != null)
            {
                objResponse.StatusCode = (int)HttpStatusCode.OK;
                objResponse.Message = CommonString.success;
                return objResponse;
            }
            else
            {
                objResponse.StatusCode = (int)HttpStatusCode.BadRequest;
                objResponse.Message = CommonString.fail;
                return objResponse;
            }
        }
    }
}
