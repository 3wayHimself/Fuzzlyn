// Generated by Fuzzlyn v1.1 on 2018-08-31 09:48:10
// Seed: 9035421983085295208
// Reduced from 132.3 KiB to 0.7 KiB in 00:08:01
// Debug: Outputs 0
// Release: Outputs 16
public class Program
{
    static ushort s_3;
    static byte s_13;
    static long s_18;
    public static void Main()
    {
        M20(0);
    }

    static void M20(short arg0)
    {
        try
        {
            System.Console.WriteLine(s_13);
        }
        finally
        {
            ushort var1 = s_3;
            ulong[] var2 = new ulong[]{1};
            s_18 = 0;
            uint var3 = 0;
            System.Console.WriteLine(var1);
            System.Console.WriteLine(var2[0]);
            System.Console.WriteLine(var3);
        }

        var vr25 = arg0--;
        var vr26 = arg0 / 4006;
        System.Console.WriteLine(vr26);
    }
}
