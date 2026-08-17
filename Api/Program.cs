
using Api.Controllers;
using Api.Repositories;
using Scalar.AspNetCore;

namespace Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();
        builder.Services.AddScoped<IRaceEventRepository, JsonRaceEventRepository>();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("LocalDevPolicy", policy =>
            {
                policy.WithOrigins("http://localhost:5173")
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference();
        }

        app.UseHttpsRedirection();
        app.UseCors("LocalDevPolicy");
        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
