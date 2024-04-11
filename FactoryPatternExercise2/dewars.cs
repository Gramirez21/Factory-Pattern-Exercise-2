using System;

public class Kata
{
    public static int PositiveSum(int[] arr)
    {

        int[] ints = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        var list = arr.Where(x => x % 2 == 0).Sum();

        return list;


    }

}
