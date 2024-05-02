using BlazorApp;
using BlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigureServices(builder.Services);

// We can move the below mentioned services into the configure services function
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();

//method 1 of adding singleton service

//builder.Services.AddSingleton<ContactService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

//other method for singletonservice

static void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<ContactService>();
    services.AddRazorPages();
    services.AddServerSideBlazor();
    //AddSingleton is added to make the service singleton
    services.AddSingleton<WeatherForecastService>();
    //add AddTransient to make the service transient
    //services.AddSingleton<ContactService>(); 
    //this creates new insiatnce each time the reload of the page happens,
    //but it is not the same in case of singleton service.
    //In singleton , till the time there is no restarting the app,
    //the instance is kept as it is.

    services.AddSingleton<IContactService, ContactService>(); 
    //services.AddSingleton<IContactService, ContactServiceTesting>(); 
    //change the above ContactService to ContactServiceTesting,
    //this way you don't have to change the dependancy in any other file.  
}