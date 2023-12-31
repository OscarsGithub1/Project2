﻿using Microsoft.AspNetCore.Mvc;
using Project2.Business;

namespace Project2.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNackademin(this IServiceCollection services)
        {
            services.Configure<MvcOptions>(options => options.Filters.Add<PageContextActionFilter>());

            return services;
        }
    }
}