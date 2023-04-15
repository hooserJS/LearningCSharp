using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace ASPCoreWebAPP1
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddTransient<IManagementCars, CarManegement>();


            var app = builder.Build();

            app.Map("/GetCarName", GetCarName);
            app.Map("/GetCarEngine", GetCarEngine);
            app.Map("/GetCarAge", GetCarAge);
            
            static void GetCarName(IApplicationBuilder app)
            {
                app.Run(async context =>
                {
                    var car = app.ApplicationServices.GetService<IManagementCars>();
                    await context.Response.WriteAsync($" Car name = {car?.GetCarName()}");
                });
            }
            static void GetCarEngine(IApplicationBuilder app)
            {
                app.Run(async context =>
                {
                    var car = app.ApplicationServices.GetService<IManagementCars>();
                    await context.Response.WriteAsync($" Car engine = {car?.GetCarEngine()}");
                });
            }
            static void GetCarAge(IApplicationBuilder app)
            {
                app.Run(async context =>
                {
                    var car = app.ApplicationServices.GetService<IManagementCars>();
                    await context.Response.WriteAsync($" Car age = {car?.GetCarAge()}");
                });
            }


            app.Run(async context =>
            {
                var car = app.Services.GetService<IManagementCars>();
                await context.Response.WriteAsync($" Car name = {car?.GetCarName()} \n Car engine = {car?.GetCarEngine()} \n Car age = {car?.GetCarAge()}");
            });
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

           // app.UseHttpsRedirection();
           // app.UseStaticFiles();

           // app.UseRouting();

           // app.UseAuthorization();

            //app.MapRazorPages();

            app.Run();
        }
    }
    interface IManagementCars
    {
        string GetCarName();
        string GetCarEngine();
        int GetCarAge();


    }
    class Cars
    {
        public string Name { get; set; }
        public string Engine { get; set; }
        public int Age { get; set; }
        public Cars(string name, string engine, int age)
        {
            Name = name;
            Engine = engine;
            Age = age;
        }
        

    }
    class CarManegement: IManagementCars 
    {
        Cars bmw = new Cars("BMW", "Disel", 12);
        public string GetCarName() => bmw.Name.ToString();
        public string GetCarEngine() => bmw.Engine.ToString();
        public int GetCarAge() => bmw.Age;
    }


    

}
