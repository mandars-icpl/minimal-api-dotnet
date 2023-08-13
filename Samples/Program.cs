using LiteDB;
using Samples.DB;
using Samples.Model;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "MyData.db";
var dbContext = new LiteDbContext(connectionString);


builder.Services.AddSingleton(dbContext);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapGet("/user", async (LiteDbContext dbContext) =>
{
    var user = dbContext.User.FindAll();
    return Results.Ok(user);
});

app.MapPost("/user", async (LiteDbContext dbContext, User newUser) =>
{
    dbContext.User.Insert(newUser);
    return Results.Created($"/user/{newUser.Id}",newUser);
});


app.Run();
