using Microsoft.EntityFrameworkCore;
using PogettoFinale.Data;
using PogettoFinale.Interfaces;
using PogettoFinale.Repository;
var builder = WebApplication.CreateBuilder(args);

// Налаштування підключення до MySQL
builder.Services.AddDbContext<BookingDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 40))));

// Реєстрація репозиторіїв в контейнері залежностей
builder.Services.AddScoped<IHotelRepository, HotelRepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();

// Додаємо сервіси для контролерів
builder.Services.AddControllers();

// Додаємо OpenAPI/Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();
app.Run();

