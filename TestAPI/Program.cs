using TestAPI.Database.IRepository;
using TestAPI.Database.Repository;
using TestAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddStackExchangeRedisCache(opt => {opt.Configuration = "localhost:6379";});
builder.Services.AddStackExchangeRedisCache(opt => { opt.Configuration = "redis://:p938bd3192434cde33f4783f3bb5d936652da3644ab29b766c9678b6187ef2b11@ec2-54-166-44-195.compute-1.amazonaws.com:29980"; });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
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
