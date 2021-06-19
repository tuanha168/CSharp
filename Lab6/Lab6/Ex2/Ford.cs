namespace Lab6.Ex2
{
  public class Ford : Car
  {
    public int weight { get; set; }
    public double GetSalePrice()
    {
      return weight > 2000 ? regularPrice - regularPrice * 10 / 100 : regularPrice - regularPrice * 20 / 100;
    }
  }
}