using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Net.Http.Headers;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Models;
using DTO;
using Models.Confirmation;
using Methods;
using Methods.Insurance;
//  using Methods.Insurance;

var builder = WebApplication.CreateBuilder(args);

//  Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthorization();

//=================Registered sevices===========
    builder.Services.AddScoped<IUserLogin, UserLogin>();
    builder.Services.AddScoped<IUserRegistration, UserRegistration>();
    builder.Services.AddScoped<IAutoInsurance, AutoInsurances>();
    builder.Services.AddScoped<ILifeInsurances, LifeInsurances>();
    builder.Services.AddScoped<IMedicalInsurance, MedicalInsurances>();
    builder.Services.AddScoped<IBusinessInsurance, BusinessInsurances>();
    builder.Services.AddScoped<IGetClaim, GetClaim >();
//-----------------------------------------------------

//===================CONFIGURATION SERVICES=========================

    builder.Services.AddCors(option => 
    {
        var site = builder.Configuration.GetValue<string>("frontEnd");
        option.AddDefaultPolicy(option => 
        {
            option.WithOrigins(site).AllowAnyHeader().AllowAnyMethod();
        });
    });

//-----------------------------------------------------------

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.UseDeveloperExceptionPage();
     app.UseSwagger();
     app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();

