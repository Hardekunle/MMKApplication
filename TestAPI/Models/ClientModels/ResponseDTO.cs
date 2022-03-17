using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace TestAPI.Models.ClientModels
{
    public class ResponseDTO
    {
        public string Message { get; set; }
        public string Error { get; set; }
    }

    public class UnprocessableModel : ObjectResult
    {
        public UnprocessableModel(ModelStateDictionary model)
            : base(model.Keys.SelectMany(x => model[x].Errors.Select(y => new ResponseDTO { Error= y.ErrorMessage, Message="" })))
        {
            StatusCode = 400;
        }

    }
}
