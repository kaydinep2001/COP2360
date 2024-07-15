using system;

namespace wine
{
  public decimal CurrentPrice { get; set; } = 123;
  public int Maximum { get; } = 999;
  public class wine
  {
    public decimal price;
    public decimal Year;
    public wine (decimal price) => Price = price;
    public wine (decimal price, int year) : this (price) => Year = year;

  }
   

}