using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApplication.Setup
{
    public class Result
    {
        public bool IsSuccess { get; private set; }
        public string[] Errors { get; private set; }

        public static Result Success()
        {
            return new Result { IsSuccess = true, Errors = Array.Empty<string>() };
        }

        public static Result Failure(params string[] errors)
        {
            return new Result { IsSuccess = false, Errors = errors };
        }
    }
}
