// Generated by Fuzzlyn on 2018-07-20 17:28:20
// Seed: 14883789923116080784
// Reduced from 24.6 KiB to 0.3 KiB
// Debug: Outputs -65
// Release: Outputs 191
public class Program
{
    static sbyte s_3 = -65;
    static short s_4;
    public static void Main()
    {
        sbyte vr3 = s_3;
        short vr4 = (short)((uint)vr3 % -4181263192027542682L);
        s_4 = vr4;
        System.Console.WriteLine(s_4);
    }
}
