// Generated by Fuzzlyn on 2018-07-10 07:57:10
// Seed: 1398148665723887491
// Reduced from 73.8 KiB to 0.2 KiB
// Debug: Outputs 65534
// Release: Outputs 4294967294
public class Program
{
    static long s_1;
    static short s_2;
    public static void Main()
    {
        s_2 = -2;
        s_1 = (char)(2L | s_2);
        System.Console.WriteLine(s_1);
    }
}
