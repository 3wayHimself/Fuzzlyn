// Generated by Fuzzlyn v1.1 on 2018-11-13 15:20:57
// Seed: 12104310804766386145
// Reduced from 272.9 KiB to 0.5 KiB in 00:06:05
// Debug: Outputs 0
// Release: Outputs -7
public class Program
{
    public static void Main()
    {
        uint vr4 = default(uint);
        var vr2 = (short)vr4;
        byte vr5 = default(byte);
        M65(vr2, vr5);
    }

    static void M65(short arg1, short arg2)
    {
        ushort var7 = default(ushort);
        try
        {
            System.Console.WriteLine(var7);
        }
        finally
        {
            arg1 = arg2--;
            arg2 /= (-10930 | 1);
        }

        System.Console.WriteLine(arg2);
    }
}
