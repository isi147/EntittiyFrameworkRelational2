namespace ConsoleApp27.Entities;

//Depend entity
public class Product
{
    //public int ID { get; set; }
    //public int ProductId { get; set; }
    //public int ProductID { get; set; }


    public int Id { get; set; }
    public string Name { get; set; }
    public int CategoryId { get; set; } //Foreign Key


    //Navigation property
    public Category Category { get; set; }
    public Order Orders { get; set; }


}
