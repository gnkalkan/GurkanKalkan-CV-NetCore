using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Results;

namespace Utilities.Results
{
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }

    public class Result(bool success, string message) : IResult
    {
        //Regular Constructor
        //public Result(bool success, string message)
        //{ 
        //    Success = success;
        //    Message = message;
        //}

        //Recurasive Constructor
        public Result(bool success):this(success, string.Empty) { }

        public bool Success { get; } = success;
        public string Message { get; } = message;

    }
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) { }
        public SuccessResult() : base(true) { }
    }

    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(true, message) { }
        public ErrorResult() : base(true) { }
    }
}

