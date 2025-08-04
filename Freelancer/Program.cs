
using Freelancer.Options;
using Freelancer.Services.GoogleDrive;

using MyCustomUmbracoProject.ExternalUserLogin.GoogleAuthentication;

using Slimsy.DependencyInjection;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddSlimsy()
    .AddDeliveryApi()
    .AddComposers()
    .AddComposers()
    .AddGoogleAuthentication()
    .Build();

builder.Services.AddHttpClient<IGoogleDriveService, GoogleDriveService>();

builder.Services.Configure<GoogleDriveOptions>(
    builder.Configuration.GetSection("GoogleDriveOptions"));

WebApplication app = builder.Build();

app.UseStaticFiles();
await app.BootUmbracoAsync();


app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseInstallerEndpoints();
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();