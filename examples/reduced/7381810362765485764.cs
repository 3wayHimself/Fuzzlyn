// Generated by Fuzzlyn on 2018-07-22 15:54:57
// Seed: 7381810362765485764
// Reduced from 259.0 KiB to 0.3 KiB
// Debug: Outputs 65535
// Release: Outputs 4294967295
public class Program
{
    static ushort[] s_2 = new ushort[]{65535};
    static ushort[, ] s_15 = new ushort[, ]{{0}};
    public static void Main()
    {
        s_15[0, 0] = s_2[0];
        char vr30 = (char)(0 ^ (sbyte)s_15[0, 0]);
        ulong vr34 = vr30;
        System.Console.WriteLine(vr34);
    }
}
