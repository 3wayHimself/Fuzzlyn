// Generated by Fuzzlyn on 2018-07-21 10:18:06
// Seed: 5857764156298902352
// Reduced from 8.8 KiB to 0.2 KiB
// Debug: Outputs 65513
// Release: Outputs 4294967273
public class Program
{
    static sbyte s_1;
    static sbyte s_3 = -23;
    public static void Main()
    {
        s_1 = s_3;
        var vr30 = (ushort)(s_1 | 1U);
        ulong vr31 = vr30;
        System.Console.WriteLine(vr31);
    }
}
