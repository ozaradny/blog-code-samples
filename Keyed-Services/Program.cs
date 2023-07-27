using Microsoft.Extensions.Caching.Memory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// builder.Services.AddSingleton<AzureFreeServices>();
// builder.Services.AddSingleton<AwsFreeServices>();
//
//
// builder.Services.AddKeyedSingleton<AzureFreeServices>("azure");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();


app.Run();


// public class AzureFreeServices(IMemoryCache cache)
// {
//      // public AzureFreeServices(IMemoryCache cache)
//      // {
//      //      
//      // }
//      public object? GetData() => cache.Get("data");
// }
//
// class AwsFreeServices(IMemoryCache cache)
// {
//      public object? GetData() => cache.Get("data");
// }