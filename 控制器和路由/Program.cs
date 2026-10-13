using System.Text.Encodings.Web;
using System.Text.Unicode;
using Microsoft.Extensions.WebEncoders;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.Configure<WebEncoderOptions>(options =>
    options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
