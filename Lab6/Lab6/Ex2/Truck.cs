namespace Lab6.Ex2
{
  public class Truck : Car
  {
    public int weight { get; set; }

    public override bool Equals(object obj)
    {
      return base.Equals(obj);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public double GetSalePrice()
    {
      return weight > 2000 ? regularPrice - regularPrice * 10 / 100 : regularPrice - regularPrice * 20 / 100;
    }

    public override string ToString()
    {
      return base.ToString();
    }
  }
}