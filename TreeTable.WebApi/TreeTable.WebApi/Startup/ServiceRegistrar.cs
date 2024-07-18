using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.FeatureManagement;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using TreeTable.WebApi.DataAccess.Repository;

namespace Chato.Server.Startup;

public static class ServiceRegistrar
{
    public const string CorsPolicy = "CorsPolicy";
    public static IServiceCollection CustomServiceRegistration(this IServiceCollection services, ConfigurationManager  configuration)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(CorsPolicy, builder => builder.WithOrigins("http://localhost:4200").
                                                               AllowAnyMethod().
                                                               AllowAnyHeader().
                                                               AllowCredentials());
        });

        services.AddSingleton<IRoomRepository, RoomRepository>();




        //services.Decorate<IUserRepository, DelegateQueueUserRepository>();


        //services.AddSingleton<ICacheItemDelegateQueue, CacheItemDelegateQueue>();


        services.AddSignalR();
        services.AddResponseCompression(options =>
        {
            options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[] { "application/octet-stream" });
        });

        //services.AddTransient<ProblemDetailsFactory, ProblemDetailsAdvanceFeaturesFactory>();

        //services.AddHostedService<PreloadBackgroundTask>();



        services.AddFeatureManagement( configuration.GetSection("FeatureFlags") );


        //kcservices.AddMiddleware


        return services;
    }

    public static IServiceCollection NativeServiceRegistration(this IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddAutoMapper(typeof(Program).Assembly);

        services.AddMemoryCache();




       services.AddSwaggerGen(options =>
        {
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            {
                Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
                In = ParameterLocation.Header,
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey
            });

            options.OperationFilter<SecurityRequirementsOperationFilter>();
        });

        //services.AddScoped<IUserService, UserService>();
        //services.AddScoped<IRegistrationValidationService, RegistrationValidationService>();


        //services.AddExceptionHandler<GlobalExceptionHandler>();
        //services.AddProblemDetails();



        services.AddHttpContextAccessor();


        return services;
    }
}