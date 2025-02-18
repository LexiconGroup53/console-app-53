using System.Text.Json.Serialization;
using API;
using API.Models;
using console_app;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

DotNetEnv.Env.Load();
string variable = Environment.GetEnvironmentVariable("SQLite_SRC");
var sitePolicy = "_site-policy";

builder.Services.AddAuthorization();
builder.Services.AddIdentityApiEndpoints<AppUser>()
    .AddEntityFrameworkStores<EducationContext>();

builder.Services.AddDbContext<EducationContext>(options =>
    options.UseSqlite(variable));
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy(sitePolicy, built =>
    {
        built.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(sitePolicy);

app.MapIdentityApi<AppUser>();
app.UseAuthorization();

app.MapPost("/link", (string user, int number) => $"User was: {user}");
app.MapPost("/form", async (HttpRequest request) =>
{
    var form = await request.ReadFormAsync();
    Person newPerson = new Person(form["firstname"], form["lastname"]);
    List<string> interests = form["interest"].ToList();
    Application newApplication = new Application(newPerson, interests); 
    return $"Form submitted by {newApplication.Person.FirstName} {newApplication.Person.LastName} who likes {
        newApplication.Interests[newApplication.Interests.Count() -1]}";
});

app.MapGet("/recognize/{number}", (int number) => WebHelp.DoWithNumber(number));
app.MapGet("/calculate/{number}", (int number) => (number - 9) * 3);
app.MapGet("/message/{name}", (string name) => $"Hello, {name}!");
app.MapGet("/boolean", () => DictionaryDemo.UseDictionary());
app.MapGet("/about/staff", () => 23 + 67);
app.MapGet("/about", () => "The about section");
app.MapGet("/", () => "Hello World!");
app.MapControllers();


app.Run();