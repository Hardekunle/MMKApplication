using System.Web.Http.Controllers;

namespace TestAPI.Services
{
    public interface IAuthService
    {
        Task<int?> ValidateUser(HttpRequest request);
    }
}
