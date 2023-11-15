var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



app.MapControllerRoute(
     name: "default",
     pattern: "{controller=home}/{action=index}/{id?}"
     );

app.Run();
