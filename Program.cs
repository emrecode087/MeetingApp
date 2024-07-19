var builder = WebApplication.CreateBuilder(args);

// MVC ÞABLONU TANITILDI
builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();    


//mvc
//rest api
//razor pages

// {controller=Home}/{action=Index}/{id?}
// app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
