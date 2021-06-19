namespace Lab4
{
  public abstract class Window
  {
    public virtual string Name { get; set; }

    protected int left;

    public Window(int top, int left)
    {
      this.top = top;
      this.left = left;
    }

    public virtual void DrawWindow() { }
  }
}