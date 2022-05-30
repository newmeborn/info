using info.Models;
using info.Repository;
using info.Repository.IRepository;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var connection = builder.Configuration.GetConnectionString("appcon");
builder.Services.AddDbContext<infoDbContext>(options => options.UseSqlServer(connection));

// specify the lifetime
// three lifetimes 1- singleton , 2-scoped , 3- transient

// singleton basically means that there will be one object and which will be used throughout the lifecycle unless you restart the application 

// scoped means when you hit the button and the request is received; that will be the scope of that object

// transient is the smallest of all lifetime,  everytime it will create a new object 
// transient is something we should be vert careful about because in a request , if an object is requested 100 times , then it will create 100 different instances of the object

// if we dont have unit of work , for all the new repository we added , we would
// have to inject them manually
// unit of work is sufficient for all the repository we will be adding in future
builder.Services.AddScoped<IUnitofWork,UnitofWork>();




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
