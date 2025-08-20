namespace Api.Models;

public class Product{
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public Product(Guid id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
        CreatedAt = DateTime.Now;
    }

}