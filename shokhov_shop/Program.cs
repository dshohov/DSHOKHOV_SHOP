using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Polly;
using shokhov_shop.Data;
using shokhov_shop.Helpers;
using shokhov_shop.Intefaces;
using shokhov_shop.Interfaces;
using shokhov_shop.Models;
using shokhov_shop.Repository;
using shokhov_shop.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddCors();//attack type CSRF prevention.
builder.Services.AddAntiforgery();//включить поддержку анти-CSRF
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.AddScoped<IChatHistoryRepository, ChatHistoryRepository>();
builder.Services.Configure<CloudinarySettings>(builder.Configuration.GetSection("CloudinarySettings"));
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();
builder.Services.AddControllersWithViews();
builder.Services.AddTransient<ISendGridEmail, SendGridEmail>();
builder.Services.AddSignalR();
builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration.GetSection("SendGrid"));
builder.Services.AddAuthentication()
.AddFacebook(options =>
{
    options.AppId = "611227601011839";
    options.AppSecret = "2ada729ca9da5bc63edbba537a0debee";
})
.AddGoogle(options =>
{
    options.ClientId = "425521569160-4ahrps3rtg863e10bnsfh9bo893nkrts.apps.googleusercontent.com";
    options.ClientSecret = "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";
});
builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequiredLength = 5;
    opt.Password.RequireLowercase = true;
    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromSeconds(10);
    opt.Lockout.MaxFailedAccessAttempts = 5;
    //opt.SignIn.RequireConfirmedAccount = true;
});
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});
builder.Services.AddHttpClient();
var app = builder.Build();
app.UseHsts(); // Prevents Mitm-attack
app.UseHttpsRedirection();//redirect http requests to https
app.UseCors(options => options.WithOrigins("https://localhost:7240").AllowAnyMethod()); //Protection against CORS attacks


// Add seed for db
if (args.Length == 1 && args[0].ToLower() == "seeddata")
{
    Seed.SeedData(app);
}

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=Woman}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapHub<ChatHub>("/chat");
});
app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Content-Security-Policy", "script-src 'self'");

    await next();

}); //Add Content Security Policy Prevents XSS-attack
app.Run();
