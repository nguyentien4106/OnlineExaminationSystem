using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
