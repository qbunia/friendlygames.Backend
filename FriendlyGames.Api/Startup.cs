﻿using System.Reflection;
using FriendlyGames.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;

namespace MyHotels.WebApi;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        // DbContext
        services.AddDbContext<FriendlyGamesDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("MssqlConnection"));
        });

        // UnitOfWork
        //services.AddTransient<IUnitOfWork, UnitOfWork>();

        // Automapper
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddControllers()
            // Solves problem with cyclical dependency between countries and hotels.
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            });
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo {Title = "FriendlyGames.Api", Version = "v1"});
        });

        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod();
            });
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FriendlyGames.Api v1"));
        }

        app.UseCors();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}