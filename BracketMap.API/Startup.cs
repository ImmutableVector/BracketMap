using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BracketMap.Business.Services;
using BracketMap.Business.Services.Interfaces;
using BracketMap.DAL.Models;
using BracketMap.DAL.Repositories;
using BracketMap.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BracketMap.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

         //This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //services.AddScoped<ITournamentService, TournamentService>();
            //services.AddScoped<ITournamentRepository, TournamentRepository>();

            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITeamRepository, TeamRepository>();

            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IPlayerRepository, PlayerRepository>();

            services.AddControllers();

            var connection = @"Server=(localdb)\mssqllocaldb;Database=BracketMap;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<BracketMapContext>
                (options => options.UseSqlServer(connection));
        }

         //This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
