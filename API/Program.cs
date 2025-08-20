using Api.Commands.Handlers;
using Api.Commands.Requests;
using API.Queries.Handlers;
using API.Queries.Requests;
using API.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var app = builder.Build();
ProductRepository productRepository = new();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.MapPost("/products", (CreateProductRequest createProductRequest) =>
{
    CreateProductHandler handler = new();
    var response = handler.Handler(createProductRequest, productRepository);
    return Results.Ok(response);
})
.WithName("Products")
.WithOpenApi();

app.MapGet("/products/id/{id}", (Guid id) =>
{
    GetProductByIdHandler handler = new();
    GetProductByIdRequest getProductByIdRequest = new(id);
    var response = handler.Handle(getProductByIdRequest, productRepository);
    return Results.Ok(response);
})
.WithName("GetProductById")
.WithOpenApi();


app.Run();
