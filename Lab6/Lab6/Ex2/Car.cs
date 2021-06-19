namespace Lab6.Ex2
{
  public abstract class Car
  {
    virtual decimal speed { get; set; }
    virtual double regularPrice { get; set; }
    virtual string color { get; set; }
    virtual double GetSalePrice();
  }
}