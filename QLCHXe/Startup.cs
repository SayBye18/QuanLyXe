﻿
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QLCHXe.Models;
using QLCHXe.Repository.Implement;
using QLCHXe.Repository.Interface;

namespace QLCHXe
{
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
            services.AddControllers();

            services.AddCors(opt =>
            {
                opt.AddPolicy("CrosPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
                });
            });


            // DI automapper
            services.AddAutoMapper(typeof(Startup));

            services.AddTransient<INhanVienRepo, NhanVienRepo>();

            services.AddTransient<IAccountRepo, AccountRepo>();

            services.AddTransient<IBaoHanhRepo, BaoHanhRepo>();

            services.AddTransient<IHdnRepo, HdnRepo>();

            services.AddTransient<IHdxRepo, HdxRepo>();

            services.AddTransient<IKhachHangRepo, KhachHangRepo>();

            services.AddTransient<IKhoRepo, KhoRepo>();

            services.AddTransient<ILoaiXeRepo, LoaiXeRepo>();

            services.AddTransient<INccRepo, NccRepo>();

            services.AddTransient<IXeRepo, XeRepo>();

            // DI của dbComtext
            services.AddDbContext<QLCHXeContext>(
                opt => opt.UseSqlServer(Configuration.GetConnectionString("quanlyxe"))
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors("CrosPolicy");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("MVC didn't find anything!");
            });

        }
    }
}
