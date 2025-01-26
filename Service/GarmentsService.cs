using GarmentStoreAPI.IService;
using GarmentStoreAPI.UserModels;

namespace GarmentStoreAPI.Service
{
    public class GarmentsService : IGarmentsService
    {
        private readonly static List<GarmentModel> garmentList = new()
        {
            new() { Id = 1, Name = "Shirts", Price = 500},
            new() { Id = 2, Name = "Pants", Price = 800}
        };
        private ResponseModel objResponse = new ResponseModel();
        
        public ResponseModel GetGarments()
        {
            objResponse.Data = garmentList;
            objResponse.StatusCode = 200;
            return objResponse;
        }
    }
}
