using LabDesk.Modules.Identity.Application.Interfaces;
using LabDesk.Modules.Identity.Domain.IRepository;
using LabDesk.Modules.Identity.Infrastructure.Persistence;
using LabDesk.Modules.Identity.Infrastructure.Persistence.Repositories;
using LabDesk.SeedWork.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabDesk.Modules.Identity.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddIdentityInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            // 1. Đăng ký DbContext với SQL Server (Chuỗi kết nối lấy từ appsettings.json)
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<IdentityDbContext>(options =>
                options.UseSqlServer(connectionString));

            // 2. Định hướng các Interface phụ về "Chủ thể chính"
            services.AddScoped<IIdentityDbContext>(provider => provider.GetRequiredService<IdentityDbContext>());
            services.AddScoped<IUnitOfWork>(provider => provider.GetRequiredService<IdentityDbContext>());

            // 3. Register Repositories
            services.AddScoped<IOrganizationRepository, OrganizationRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
