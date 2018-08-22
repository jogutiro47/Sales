namespace Sales.Services
{
    using Sales.Common.Models;
    using System;
    using System.Threading.Tasks;

    public class ApiService
    {
        public async Task<Response> GetList<T>(string urlbase, string prefix, string controller)
        {
            try
            {

            }
            catch (Exception ex)
            {

                return new Response
                {
                    IsSuccess = false,
                    Message = ex.Message,

                };
            }
        }
    }
}
