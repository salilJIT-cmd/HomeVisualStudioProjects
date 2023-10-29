using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using System.Drawing;
using static System.Net.WebRequestMethods;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;

namespace WebAPI_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // used to create a web application builder.
            // This builder is the starting point for configuring and building your application.
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            // registers the MVC services for your application.
            // It enables the use of controllers to handle HTTP requests.
            builder.Services.AddControllers();


            // These lines configure Swagger, a tool for documenting and testing APIs.
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // creates an instance of your web application.
            var app = builder.Build();


            // Configure the HTTP request pipeline.

            // These lines check if the application is running in the development environment.
            // If it is, it adds Swagger and Swagger UI to the request pipeline.
            // Swagger provides interactive API documentation,
            // and Swagger UI is a user-friendly interface for exploring and testing your API.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            // This middleware redirects HTTP requests to HTTPS.
            // It's a common practice to ensure secure communication with your API.
            // Example ==>
            // With UseHttpsRedirection middleware enabled,
            // when the user tries to access http://example.com/api/data,
            // the middleware detects the HTTP request and responds
            // with an HTTP 302 (Redirect) status code, instructing the user's browser
            // to switch to an equivalent HTTPS URL.
            app.UseHttpsRedirection();


            // By using UseAuthorization middleware, you can control access to
            // various parts of your application, ensuring that only
            // authorized users can perform certain actions
            app.UseAuthorization();


            // app.MapControllers() maps controller actions to HTTP routes,
            // enabling your API to handle incoming requests based on the attributes
            // and routing configured in your controllers.
            app.MapControllers();


            // starts the application, making it ready to listen for incoming HTTP requests.
            app.Run();


            // Summary
            // In summary, the Program.cs file is the entry point of your ASP.NET Core Web API.
            // It configures and builds the web application, sets up services and middleware,
            // and starts the application to listen for incoming HTTP requests.
            // It also enables Swagger for API documentation
            // when running in the development environment.
        }
    }
}