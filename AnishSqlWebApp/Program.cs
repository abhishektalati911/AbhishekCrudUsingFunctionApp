using AnishSqlWebApp.Services;

var builder = WebApplication.CreateBuilder(args);

var azureAppConfigConnectionString = "Endpoint=https://azureappconfigresourcegroup.azconfig.io;Id=cxm+-lh-s0:HbBgzjj/WuM4QmPmRhty;Secret=yUxxucgc6W1rZdVHj2Fxpj7Xm54k839hq2uOvnkhMSU=";

builder.Host.ConfigureAppConfiguration(builder =>
{
    builder.AddAzureAppConfiguration(azureAppConfigConnectionString);
});

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddTransient<ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
