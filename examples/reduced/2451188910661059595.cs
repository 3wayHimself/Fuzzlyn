// Generated by Fuzzlyn on 2018-06-26 04:53:10
// Seed: 2451188910661059595
// Reduced from 252.5 KiB to 0.3 KiB
// Debug: Outputs 65416
// Release: Outputs -120
public class Program
{
    static char s_13;
    static sbyte s_20 = -120;
    public static void Main()
    {
        char vr19 = (char)M32();
        System.Console.WriteLine((int)vr19);
    }

    static ushort M32()
    {
        return (ushort)(s_20 ^ s_13);
    }
}
