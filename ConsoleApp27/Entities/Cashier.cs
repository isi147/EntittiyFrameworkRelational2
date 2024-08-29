namespace ConsoleApp27.Entities;

//Princple entity
public class Cashier
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public ICollection<Order> Orders { get; set; }
}
