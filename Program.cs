using DI.Lifetime.Sample.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddTransient<ITransientOperation, TransientOperation>();
builder.Services.AddScoped<IScopedOperation, ScopedOperation>();
builder.Services.AddSingleton<ISingletonOperation, SingletonOperation>();
builder.Services.AddTransient<OperationService, OperationService>();

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
