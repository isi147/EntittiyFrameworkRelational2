namespace ConsoleApp27.Entities;

//Depend Entity
public class Order
{
    public int Id { get; set; }
    public string Adress { get; set; }
    public int ProductId { get; set; }
    public int CashierId { get; set; }

    public Cashier Cashier { get; set; }
    public Product Product { get; set; }
}
