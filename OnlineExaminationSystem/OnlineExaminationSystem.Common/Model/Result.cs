using Microsoft.AspNetCore.Mvc;

namespace OnlineExaminationSystem.Common.Model
{
    public class Result : ActionResult
    {
        public Result(string error)
        {
            Message = error;
            IsSuccessful = false;
        }

        public Result()
        {
            IsSuccessful = true;
            Message = string.Empty;
        }

        public string Message { get; set; }

        public bool IsSuccessful { get; set; }

        public static Result Success => new();

        public Task ExecuteResultAsync(ActionContext context)
        {
            throw new NotImplementedException();
        }
    }
}