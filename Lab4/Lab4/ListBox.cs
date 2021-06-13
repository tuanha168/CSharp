using System;

namespace Lab4
{
  public class ListBox : Window
  {
    private string mListContents { get; set; }

    public ListBox(int top, int left, string mListContents) : base(top, left)
    {
      this.mListContents = mListContents;
    }

    public override void DrawWindow()
    {
      Console.WriteLine($"Writing string to the listbox: {mListContents}");
    }

  }
}