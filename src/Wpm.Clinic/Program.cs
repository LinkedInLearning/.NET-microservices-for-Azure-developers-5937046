using Microsoft.EntityFrameworkCore;
using Wpm.Clinic.DataAccess;
using Wpm.Clinic.ExternalServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ManagementService>();
builder.Services.AddDbContext<ClinicDbContext>(options =>
{
    options.UseInMemoryDatabase("WpmClinic");
});
builder.Services.AddHttpClient<ManagementService>(client =>
{
    var uri = builder.Configuration.GetValue<string>("Wpm__ManagementUri");
    client.BaseAddress = new Uri(uri);
});

var app = builder.Build();

app.EnsureClinicDbIsCreated();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
