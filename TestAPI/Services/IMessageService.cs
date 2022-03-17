using TestAPI.Models.ClientModels;

namespace TestAPI.Services
{
    public interface IMessageService
    {
        Task<bool> InBoundRequest(int loggedInUserId,SMSDTO request);
        Task<bool> OutBoundRequest(int loggedInUserId, SMSDTO request);
    }
}
