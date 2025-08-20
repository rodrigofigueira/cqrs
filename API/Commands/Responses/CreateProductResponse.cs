namespace Api.Commands.Responses;

public record CreateProductResponse(Guid Id, string Name, string Description, DateTime CreatedAt){}