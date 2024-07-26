using Microsoft.AspNetCore.Cors.Infrastructure;
using TreeTable.WebApi.Services;
using TreeTable.WebApi.Startup;

 const string CorsPolicy = "CorsPolicy";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.NativeServiceRegistration();
//builder.Services.CustomServiceRegistration(builder.Configuration);

builder.Services.AddCors(options =>
{
    options.AddPolicy(CorsPolicy, builder => builder.WithOrigins("http://localhost:4200").
                                                       AllowAnyMethod().
                                                       AllowAnyHeader().
                                                       AllowCredentials());
});


builder.Services.AddTransient<IPeopleService, PeopleService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(CorsPolicy);
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
