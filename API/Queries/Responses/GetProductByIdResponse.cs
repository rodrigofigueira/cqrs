namespace API.Queries.Responses;

public record GetProductByIdResponse(Guid Id, string Name, string Description, DateTime CreatedAt) {}
