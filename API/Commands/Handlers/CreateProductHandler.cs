using Api.Commands.Responses;
using Api.Commands.Requests;
using API.Repository;
using Api.Models;

namespace Api.Commands.Handlers;

public class CreateProductHandler(){
    public CreateProductResponse Handler(CreateProductRequest createProductRequest, ProductRepository repository){

        Product retorno = repository.Add(createProductRequest.Name, createProductRequest.Description);

        return new CreateProductResponse(retorno.Id, 
                                        retorno.Name,
                                        retorno.Description,
                                        retorno.CreatedAt);
    }
}