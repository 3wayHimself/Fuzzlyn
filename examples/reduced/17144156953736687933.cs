// Generated by Fuzzlyn v1.1 on 2018-11-14 10:47:25
// Seed: 17144156953736687933
// Reduced from 141.0 KiB to 0.4 KiB in 00:01:45
// Debug: Outputs 0
// Release: Outputs 2
public class Program
{
    static sbyte[] s_26;
    public static void Main()
    {
        s_26 = new sbyte[]{0};
        M42(0);
    }

    static void M42(sbyte arg1)
    {
        try
        {
            arg1 = -1;
        }
        finally
        {
            System.Console.WriteLine(arg1);
        }

        arg1 = s_26[0];
        arg1 /= -128;
        System.Console.WriteLine(arg1);
    }
}
