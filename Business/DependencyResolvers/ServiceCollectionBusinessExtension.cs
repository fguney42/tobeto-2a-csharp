using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers
{
    public static class ServiceCollectionBusinessExtension
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            // Scoped services
            services.AddScoped<IModelService, ModelManager>()
                    .AddScoped<IModelDal, EfModelDal>()
                    .AddScoped<ModelBusinessRules>();

            services.AddScoped<IBrandService, BrandManager>()
                    .AddScoped<IBrandDal, EfBrandDal>()
                    .AddScoped<BrandBusinessRules>();

            services.AddScoped<IFuelService, FuelManager>()
                    .AddScoped<IFuelDal, EfFuelDal>()
                    .AddScoped<FuelBusinessRules>();
            services.AddScoped<ITokenHelper, JwtTokenHelper>();

            services.AddScoped<ITransmissionService, TransmissionManager>()
                    .AddScoped<ITransmissionDal, EfTransmissionDal>()
                    .AddScoped<TransmissionBusinessRules>();

            services.AddScoped<IUserService, UserManager>()
                    .AddScoped<IUserDal, EfUserDal>()
                    .AddScoped<UserBusinessRules>();

            services.AddScoped<ICustomerService, CustomerManager>()
                    .AddScoped<ICustomerDal, EfCustomerDal>()
                    .AddScoped<CustomerBusinessRules>();

            services.AddScoped<IIndividualCustomerService, IndividualCustomerManager>()
                    .AddScoped<IIndividualCustomerDal, EfIndividualCustomerDal>()
                    .AddScoped<IndividualCustomerBusinessRules>();

            services.AddScoped<ICorporateCustomerService, CorporateCustomerManager>()
                    .AddScoped<ICorporateCustomerDal, EfCorporateCustomerDal>()
                    .AddScoped<CorporateCustomerBusinessRules>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Register the RentACarContext as scoped, not singleton
            services.AddDbContext<RentACarContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22"))
            );

            return services;
        }
    }
}
