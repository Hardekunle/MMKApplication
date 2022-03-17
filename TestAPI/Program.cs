using TestAPI.Database.IRepository;
using TestAPI.Database.Repository;
using TestAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddStackExchangeRedisCache(opt => {opt.Configuration = "localhost:6379";})
builder.Services.AddStackExchangeRedisCache(opt => {
    opt.Configuration = "redis://:pa0e41a9c3e5d72af6276d5a282c0b3b6db009c6f8f65f9ab8ae3cda1134d94d2@ec2-54-161-214-108.compute-1.amazonaws.com:15260";
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.Services.AddSingleton<ICacheService, RedisCacheService>();
builder.Services.AddScoped<IAccountRepo, AccountRepo>();
builder.Services.AddScoped<IPhoneBookRepo, PhoneBookRepo>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IMessageService, MessageService>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()|| app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
