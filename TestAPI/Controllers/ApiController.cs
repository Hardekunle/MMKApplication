//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Controllers;
using TestAPI.Models.ClientModels;
using TestAPI.Services;

namespace TestAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly IMessageService _messageService;
        private readonly ICacheService _cacheService;
        
        public ApiController(IAuthService authService, IMessageService messageService, ICacheService cacheService)
        {
            _authService = authService;
            _messageService = messageService;
            _cacheService = cacheService;
        }

        //[HttpGet]
        //[Route("tester")]
        //public IActionResult CheckAction()
        //{
        //    return Ok("This is it here");
        //}


        [HttpPost]
        [Route("inbound/sms")]
        public async Task<IActionResult> InBoundAction([FromBody]SMSDTO inboundSMS)
        {
            try
            {
                int? authUserId = await _authService.ValidateUser(HttpContext.Request);
                if (authUserId == null) return StatusCode(403);

                var result = await _messageService.InBoundRequest(1,inboundSMS);

                return StatusCode(200, new ResponseDTO { Message = "inbound sms ok", Error="" });
            }
            catch(Exception ex)
            {
                return StatusCode(400, new ResponseDTO { Message ="", Error= ex.Message });
            }

        }


        [HttpPost]
        [Route("outbound/sms")]
        public async Task<IActionResult> OutBoundAction([FromBody]SMSDTO outBoundSMS)
        {
            try
            {
                int? authUserId = await _authService.ValidateUser(HttpContext.Request);
                if (authUserId == null) return StatusCode(403);

                var result = await _messageService.OutBoundRequest(1, outBoundSMS);

                return StatusCode(200, new { Message = "outbound sms ok", Error="" });

            }
            catch(Exception ex)
            {
                return StatusCode(400, new { Message="", Error = ex.Message });
            }

        }
    }
}
