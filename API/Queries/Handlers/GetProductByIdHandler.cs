using API.Queries.Requests;
using API.Queries.Responses;
using API.Repository;

namespace API.Queries.Handlers
{
    public class GetProductByIdHandler
    {
        public GetProductByIdResponse Handle(GetProductByIdRequest getProductByIdRequest, ProductRepository repository)
        {
            var product = repository.GetById(getProductByIdRequest.Id);

            if (product is null) return null;

            return new GetProductByIdResponse(product.Id, product.Name, product.Description, product.CreatedAt);
        }
    }
}
