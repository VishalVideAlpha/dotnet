var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();  //  REQUIRED for Swagger to discover endpoints
builder.Services.AddOpenApi();

var app = builder.Build();


    // Expose OpenAPI spec
    app.MapOpenApi();

    // Serve Swagger UI
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "My API v1");
        options.RoutePrefix = "swagger"; // optional: serves at /swagger
    });


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
