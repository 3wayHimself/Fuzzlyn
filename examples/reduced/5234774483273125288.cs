// Generated by Fuzzlyn on 2018-07-25 22:37:48
// Seed: 5234774483273125288
// Reduced from 13.3 KiB to 0.2 KiB
// Debug: Outputs 65408
// Release: Outputs 4294967168
public class Program
{
    static sbyte[] s_2 = new sbyte[]{-127};
    public static void Main()
    {
        var vr14 = (ushort)(s_2[0] ^ 1U);
        ulong vr15 = vr14;
        System.Console.WriteLine(vr15);
    }
}
