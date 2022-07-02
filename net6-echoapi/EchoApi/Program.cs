using System.Text;

var builder = WebApplication.CreateBuilder(args);

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

app.UseHttpsRedirection();

var version = Environment.GetEnvironmentVariable("VERSION") ?? "1.0.0";

app.MapGet("/", () => $"version {version}");
app.MapGet("/success",()=> Results.Ok("success"));
app.MapGet("/fail", () => Results.BadRequest("fail"));
app.MapGet("/404", () => Results.NotFound());

app.MapMethods("/echo", new[] { "GET", "POST","PUT","DELETE" }, (HttpContext context,HttpRequest request,HttpResponse response) => {
    using (var stream = new StreamReader(request.Body)) {
        var body = stream.ReadToEndAsync();
        var headers = new StringBuilder();
        foreach (var item in request.Headers)
        {
            headers.AppendLine($"{item.Key}: {item.Value}");
        }
        response.WriteAsync($"Request={request.Method} {request.Path}{request.QueryString} {request.Protocol}\n");
        response.WriteAsync($"Headers={headers.ToString()}");
        response.WriteAsync($"Body={body}");   
    }
});

app.Run();
