var builder = WebApplication.CreateBuilder(args);

/* Install Services using the builder.Services methods
 */

//Enable MVC and DIJ Services for this application
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<LuckySpin.Services.TextTransform>();
//TODO: Do Step 0) Here for both the Repository and Player classes as Singleton services

builder.Services.AddSingleton<LuckySpin.Services.Repository>();
builder.Services.AddSingleton<LuckySpin.Models.Player>();


var app = builder.Build();


/* Middleware in the HTTP Request Pipeline
 */
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/", //NOTE: Changed from "{controller}/{action}/{id?}". Why?
    defaults: new
    {
        controller = "Spinner",
        action = "Index"
    });

app.Run();


