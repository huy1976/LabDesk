using FluentValidation;
using LabDesk.SeedWork.Application.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace LabDesk.SeedWork.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationSeedWork(
        this IServiceCollection services,
        Assembly assembly)
    {
        // 1. Tự động đăng ký MediatR và các Handlers thuộc Assembly truyền vào
        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(assembly);

            // Đăng ký Pipeline Behavior tự động validate
            cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
        });

        // 2. Tự động tìm và đăng ký tất cả FluentValidation Validators
        services.AddValidatorsFromAssembly(assembly);

        return services;
    }
}
