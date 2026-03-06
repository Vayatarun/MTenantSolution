using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MTenantSolution.Model.IdentityModel;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MTenantSolution.Data.Areas.Identity.Data.ApplicationDbContext>(options => options.UseInMemoryDatabase("ApplicationdbContext"));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
    options =>
    {
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 6;
        options.Password.RequiredUniqueChars = 0;
    }
    )
    .AddEntityFrameworkStores<MTenantSolution.Data.Areas.Identity.Data.ApplicationDbContext>()
    .AddDefaultTokenProviders();


builder.Services.AddAuthentication(optiones =>
{
    optiones.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    optiones.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    optiones.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
})
                .AddJwtBearer(o =>
                    o.TokenValidationParameters = new TokenValidationParameters
                    {
                        //ValidAudience = builder.Configuration["TokenConfiguration:Audience"],
                        //ValidIssuer = builder.Configuration["TokenConfiguration:Issuer"],
                        //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenConfiguration:SecretKey"]!)),
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                        ValidateLifetime = true,
                        ClockSkew = TimeSpan.Zero,
                    }
                );

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "MTenantSolution API",
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "MTenantSolution API V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();



app.MapControllerRoute(
name: "areas",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
app.Run();
