using System;

namespace cs_split
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] arr;

      string csv = "飲料用 ヨーグルト,鳥弁当,レーズンデニッシュ,カップ-トマトスープ,カップ-きのこスープ";

      arr = csv.Split(',');

      forprint(arr);

      arr = csv.Split(',', ' ');

      forprint(arr);

      arr = csv.Split(", -".ToCharArray());

      forprint(arr);

      arr = csv.Split("カップ-", StringSplitOptions.None);

      forprint(arr);

      arr = csv.Split("カップ-");

      forprint(arr);
      
    }

    private static void forprint(string[] arr)
    {
      Console.WriteLine();

      for (int i = 0; i < arr.Length; i++)
      {
        Console.WriteLine($"{i} : {arr[i]}");
      }
    }
  }
}

