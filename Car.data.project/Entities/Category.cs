

namespace Car.Data.Project.Entities;

public class Category : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<product>? products { get; set; }
}
