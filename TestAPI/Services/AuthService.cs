using System.Security.Principal;
using System.Text;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using TestAPI.Database.IRepository;
using TestAPI.Models.DatabaseModels;

namespace TestAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly IAccountRepo _accountRepo;

        public AuthService(IAccountRepo accountRepo)
        {
            _accountRepo = accountRepo;
        }

        public async Task<int?> ValidateUser(HttpRequest request)
        {
            string authHeader = request.Headers["Authorization"];
            if (authHeader != null && authHeader.StartsWith("Basic"))
            {
                var authToken= authHeader.Substring("Basic ".Length).Trim();
                return await ValidateToken(authToken);
            }
            return null;

        }

        private async Task<int?> ValidateToken(string authToken)
        {

            string decodedToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
            var loginDetails = decodedToken.Split(":");
            if (loginDetails.Length != 2)
            {
                return null;
            }
            else
            {
                string username = loginDetails[0];
                string password = loginDetails[1];

                Account user = await _accountRepo.GetAccountByUsername(username);

                if (user == null || !user.Auth_Id.Equals(password))
                    return null;

                return user.Id;
            }
        }
    }

    //public class BasicAuthAttribute : AuthorizationFilterAttribute
    //{
    //    //private readonly IAuthService _authService;
    //    //public BasicAuthAttribute(IAuthService authService)
    //    //{
    //    //    _authService = authService;
    //    //}


    //    public override void OnAuthorization(HttpActionContext actionContext)
    //    {
    //        if (actionContext.Request.Headers.Authorization == null)
    //        {
    //            actionContext.Response.StatusCode = System.Net.HttpStatusCode.Forbidden;
    //        }
    //        //else
    //        //{
    //        //    string authToken = actionContext.Request.Headers.Authorization.Parameter;
    //        //    ValidateToken(actionContext,authToken);
    //        //}

    //    }

    //    private void ValidateToken(HttpActionContext actionContext, string authToken)
    //    {

    //        string decodedToken = Encoding.UTF8.GetString(Convert.FromBase64String(authToken));
    //        var loginDetails = decodedToken.Split(":");
    //        if (loginDetails.Length != 2)
    //        {
    //            actionContext.Response.StatusCode = System.Net.HttpStatusCode.Forbidden;
    //        }
    //        else
    //        {
    //            string username = loginDetails[0];
    //            string password = loginDetails[1];

    //            if (_authService.ValidateUser(username, password))
    //            {
    //                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
    //            }
    //            else
    //            {
    //                actionContext.Response.StatusCode = System.Net.HttpStatusCode.Forbidden;
    //            }
    //        }
    //    }
    //    }
}
