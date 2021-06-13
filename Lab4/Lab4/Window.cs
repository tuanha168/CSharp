namespace Lab4
{
  public abstract class Window
  {
    protected int top;
    protected int left;

    public Window(int top, int left)
    {
      this.top = top;
      this.left = left;
    }

    public virtual void DrawWindow() { }
  }
}