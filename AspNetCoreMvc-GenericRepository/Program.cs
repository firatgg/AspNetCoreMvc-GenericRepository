using AspNetCoreMvc_GenericRepository.Data;
using AspNetCoreMvc_GenericRepository.Interface;
using AspNetCoreMvc_GenericRepository.Reporsitories;
using Microsoft.EntityFrameworkCore;
using System;

namespace AspNetCoreMvc_GenericRepository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<UrunDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));

            builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

       


         app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
