// Generated by Fuzzlyn on 2018-07-17 05:32:10
// Seed: 3313352718416321757
// Reduced from 91.8 KiB to 0.3 KiB
// Debug: Throws 'System.OverflowException'
// Release: Runs successfully
public class Program
{
    public static void Main()
    {
        var vr27 = new char[][]{new char[]{'W'}};
        char vr29 = vr27[0][0];
        short vr31 = (short)(0 & (-2147483648 % ('a' | (short)(2147483646 ^ (0 % vr29)))));
        System.Console.WriteLine(vr31);
    }
}
