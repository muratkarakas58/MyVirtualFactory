using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactoryClientType1.Models
{
    public class Result<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public Result(bool success, string message, T data)
        {
            Success = success;
            Message = message;
            Data = data;
        }
    }
}
