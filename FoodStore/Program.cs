using FoodStore.Data.interfaces;
using FoodStore.Data.Mocks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();
// used to configure all the services thats been created 
// Services is used to access the list of different services.
// everytime an interface is invoked we will get back a new concrete interface implementation
//added a new credential 
builder.Services.AddTransient<IDrinkRepository, MockDrinkRepository >();
builder.Services.AddTransient<ICategoryRepository, MockCategoryRepository>();
builder.Services.AddTransient<IFoodRepository, MockFoodRepository>();
builder.Services.AddMvc();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
app.UseMvcWithDefaultRoute();
app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
