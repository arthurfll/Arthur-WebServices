using Microsoft.EntityFrameworkCore;
using Server.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
//app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();

