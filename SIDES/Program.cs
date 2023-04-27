using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Serilog;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
  .ReadFrom.Configuration(builder.Configuration)
  .Enrich.FromLogContext()
  .CreateLogger();
builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);




// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SidesDBConnection");
//builder.Services.AddRazorPages(Options =>
//{
//    Options.Conventions.AddPageRoute("/UI_SIDES/SidesRequest/SidesRequestV", "");
//});

builder.Services.AddDbContextPool<UCAContext>(options =>
{
    options.UseSqlServer(connectionString);
     options.EnableSensitiveDataLogging();
});
builder.Services.AddScoped<ISidesTPARequest, SidesTPARequest>();
builder.Services.AddScoped<ISidesTPAResponse, SidesTPAResponse>();
builder.Services.AddScoped<ISidesResponse_ClaimantInformation, Sides_ClaimantInformation>();
builder.Services.AddScoped<IFlagRequestStatus, FlagRequestStatus>();







builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
   // app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    // app.UseHsts();
}
else
{
 //   app.UseExceptionHandler("/UI_SIDES/CentralizedError/{0}");
   // app.UseHsts();
  
}
app.UseStatusCodePagesWithRedirects("/CentralizedError/{0}");

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute(
//      name: "default",
//      pattern: "{controller=Home}/{action=Index}/{id?}"



//    );
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "area",
      pattern: "{area:exists}/{controller}/{action}/{Id?}"
    // pattern: "{area = ui_sides}/{controller = sidesrequest }/{action = sidesrequestv}/{Id?}"

    );


    endpoints.MapAreaControllerRoute(
                   name: "default",
                   areaName: "UI_SIDES",
                   pattern: "{controller=SidesRequest}/{action=SidesRequestV}");
});



app.Run();
