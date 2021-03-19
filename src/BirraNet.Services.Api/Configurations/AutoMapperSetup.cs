using AutoMapper;
using BirraNet.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BirraNet.Services.Api.Configurations
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(EntityToViewModelProfile), typeof(ViewModelToEntityProfile));            
        }
    }
}
