using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Authorization;
using WebAPI.Services;

namespace WebAPI.Dependencies
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection service)
        {
            service.AddScoped<IUserService, UserService>();
            service.AddScoped<IJwtUtils, JwtUtils>();
        }

        public static void AddValidationsDependency(this IServiceCollection service)
        {
            //service.AddMvc().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<RoleValidator>());
        }

    }
}

