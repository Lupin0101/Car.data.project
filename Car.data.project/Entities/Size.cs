
namespace Car.Data.Project.Entities;

public class Size : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public OptionType OptionType { get; set; }
    public List<product>? products { get; set; }
}
