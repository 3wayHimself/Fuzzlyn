// Generated by Fuzzlyn on 2018-07-03 08:32:59
// Seed: 13973128871248872243
// Reduced from 52.6 KiB to 0.3 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
class C0
{
    public ushort F6;
}

public class Program
{
    static C0[, ] s_1 = new C0[, ]{{new C0()}};
    public static void Main()
    {
        M1();
    }

    static long M1()
    {
        return ((0 & s_1[0, 0].F6) + s_1[0, 0].F6);
    }
}
