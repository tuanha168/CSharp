namespace Lab3
{
  public class SelectionSort
  {
    public static int[] sort(int[] arr)
    {
      int temp, smallest;
      for (int i = 0; i < arr.Length; i++)
      {
        smallest = i;
        for (int j = i + 1; j < arr.Length - 1; j++)
        {
          if (arr[j] < arr[smallest])
          {
            smallest = j;
          }
        }
        temp = arr[smallest];
        arr[smallest] = arr[i];
        arr[i] = temp;
      }
      return arr;
    }
  }
}