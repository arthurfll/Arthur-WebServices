using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
  public class Venda
  {
    [Key]
    public int Id {get;set;}
    public int PizzaId {get;set;}
    public int Quantity {get;set;}
    public DateTime Date {get;set;}
  }
}

