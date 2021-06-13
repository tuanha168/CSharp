namespace Lab4
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Window list1 = new ListBox(1, 2, "haha");
      Window list2 = new ListBox(3, 4, "hehe");
      Window button = new Button(5, 6);
      list1.DrawWindow();
      list2.DrawWindow();
      button.DrawWindow();
    }
  }
}
