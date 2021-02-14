using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeVoos.Domain.Response
{
    public abstract class BaseResponse<T>
    {
        public bool Status { get; set; }

        public List<string> Message { get; set; }

        public T Resource { get; set; }

        protected BaseResponse(bool status)
        {
            Status = status;
            Message = new List<string>();
            Resource = default;
        }

        protected BaseResponse(T resource)
        {
            Status = false;
            Message = new List<string>();
            Resource = resource;
        }

        protected BaseResponse(List<string> message)
        {
            Status = false;
            Message = message;
            Resource = default;
        }

        protected BaseResponse(List<string> message, bool status)
        {
            Status = status;
            Message = message;
            Resource = default;
        }

        protected BaseResponse(ValidationResult validationResult)
        {
            Message = new List<string>();

            foreach(var error in validationResult.Errors)
            {
                Message.Add(error.ErrorMessage);
            }
            Status = false;
            Resource = default;
        }
    }
}
