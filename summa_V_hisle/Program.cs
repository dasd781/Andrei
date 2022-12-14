using System;
 
class GFG {

    static int getSum(int n)
    {
        int sum = 0;
 
        while (n != 0) {
            sum = sum + n % 10;
            n = n / 10;
        }
 
        return sum;
    }
 
    
    public static void Main()
    {
        int n = 687;

        Console.Write(getSum(n));
    }
}
 