using CRM.WebBlazor.Service.Identity;
using Microsoft.AspNetCore.Localization;
using MTenantSolution.BlazorApp.Components;
using MTenantSolution.BlazorApp.Service;
using MTenantSolution.BlazorApp.Service.Identity;
using MudBlazor;
using MudBlazor.Services;
using System.Globalization;
var builder = WebApplication.CreateBuilder(args);


var apiBaseUrl = builder.Configuration["ApiBaseAddress"];


builder.Services.AddHttpClient("DefaultClient", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl);
});
builder.Services.AddLocalization();
var supportedCultures = new[] { new CultureInfo("en"), new CultureInfo("nl") };
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddMudServices();
builder.Services.AddScoped<TokenStore>();
builder.Services.AddScoped<RefreshTokenHandler>();
builder.Services.AddScoped<AuthenticatedHttpClientService>();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddScoped<IErrorHandlingService, ErrorHandlingService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.VisibleStateDuration = 10000;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
