
using Microsoft.OpenApi.Models;
using Services;
using Interfaces;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MortgageFraudContexts;
using Interfaces;

namespace WebApplication9
{
    public class Program
    {
        public static void Main(string[] args)
        {



            var builder = WebApplication.CreateBuilder(args);




            builder.Services.AddControllers();

            builder.Services.AddScoped<IMortagageFraudService, MortgageFraudService>();



            //builder.Services.AddScoped<IAddressDocService, AddressDocService>();    

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();



            var app = builder.Build();

            app.UseAuthorization();





            // Configure the HTTP request pipeline.

            if (app.Environment.IsDevelopment())

            {

                app.UseSwagger();

                app.UseSwaggerUI();

            }





            app.UseHttpsRedirection();



            app.UseAuthorization();



            app.MapControllers();



            app.Run();
        }
    }
}