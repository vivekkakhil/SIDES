using Microsoft.AspNetCore.Builder;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using SIDES.EFCoreModels.ScafffoldEntities.Persistance;
using SIDES.Interface;
using SIDES.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("SidesDBConnection");
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
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

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
      name: "areas",
      pattern:"{area}/{controller}/{action}/{Id?}"
  //  pattern: "{area = UI_SIDES}/{controller = SidesRequest }/{action = SidesRequestV}/"

    );
});



app.Run();
