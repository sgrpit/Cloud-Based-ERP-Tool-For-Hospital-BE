using Cloud_Based_ERP_Tool_For_Hospital_BE.Middleware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud_Based_ERP_Tool_For_Hospital_BE.Utilites
{
    public class ApiResponse<T>
    {
        public ApiResponse()
        {

        }

        public ApiResponse(T data)
        {
            Succeeded = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }

        public ApiResponse(T data, bool succeded = true, string message = "", AppException error = null)
        {
            Succeeded = succeded;
            Message = message;
            Errors = error;
            Data = data;
        }

        public T Data { get; set; }
        public bool Succeeded { get; set; }
        public AppException Errors { get; set; }
        public string Message { get; set; }
    }
}
