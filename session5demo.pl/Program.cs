using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using session5demo.bl.Common.EmployeeMapperProfile;
using session5demo.bl.Common.MapperProfile;
using session5demo.bl.Sevices.DpartmentServices;
using session5demo.bl.Sevices.EmployeeServices;
using session5demo.dl.Contexts;
using session5demo.dl.Reposatory.DepartmentReposartoy;
using session5demo.dl.Reposatory.DepartmentReposartoy.IdepartmentReposatory;
using session5demo.dl.Reposatory.Employee_Reposatory;
using session5demo.dl.Reposatory.Genericrepo;
using session5demo.dl.Reposatory.Iemployeerepo;
using session5demo.dl.Reposatory.IGenericreposatory;

namespace session5demo.pl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<demoContexsts>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
            builder.Services.AddScoped<IdepartmentRepo, DepartmentRepo>();
            builder.Services.AddScoped<IemployeeReposatory, EmployeeReposatory>();
            builder.Services.AddScoped<IdepartmentServices, DepartmentServices>();
            builder.Services.AddScoped<IemployeeServices, EmployeeServices>();
            builder.Services.AddAutoMapper(m=>m.AddMaps(typeof(DepartmentProfile).Assembly));
            builder.Services.AddAutoMapper(m => m.AddMaps(typeof(EmployeeProfile).Assembly));



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
