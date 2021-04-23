﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using NLayerProject.API.DTOs;
using NLayerProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Filters
{
    public class NotFoundFilter:ActionFilterAttribute
    {
        private readonly IProductService _productService;

        public NotFoundFilter(IProductService productService)
        {
            _productService = productService;
        }

        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = (int)context.ActionArguments.Values.FirstOrDefault();
            var product = await _productService.GetByIdAsync(id);
            if(product != null)
            {
                //gelen requeste devam et. Hangi action metodundaysan o metodun içine gir.
                await next();
            }
            else
            {
                ErrorDto errorDto = new ErrorDto();
                errorDto.Status = 404;
                errorDto.Errors.Add($"id'si {id} olan ürün veri tabanında bulunamadı.");

                context.Result = new NotFoundObjectResult(errorDto);
            }
        }
    }
}
