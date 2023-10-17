using Infrastructure.CustomerConfiguration.Google;

[assembly: HostingStartup(typeof(Infrastructure.CustomerConfiguration.AddConfigurations))]
var builder = WebApplication.CreateBuilder(args);

// 加入組態設定
builder.Services.ConfigureGoogleService(builder.Configuration);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvc();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(name: "",
//                      policy =>
//                      {
//                          policy.WithOrigins("http://example.com",
//                                              "http://www.contoso.com");
//                      });
//});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapAreaControllerRoute(
    name: "MyAreaProducts",
    areaName: "Products",
    pattern: "Products/{controller=Home}/{action=Index}/{id?}");

app.Run();