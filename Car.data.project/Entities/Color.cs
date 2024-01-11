
namespace Car.Data.Project.Entities;

public class Color : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public OptionType OptionType { get; set; }
    public List<product>? products { get; set; }
}
