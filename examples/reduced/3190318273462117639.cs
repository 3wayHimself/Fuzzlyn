// Generated by Fuzzlyn on 2018-06-19 21:15:57
// Seed: 3190318273462117639
// Reduced from 80.1 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static sbyte[, ] s_1 = new sbyte[, ]{{0}};
    public static void Main()
    {
        ulong vr3 = (ulong)(0 & s_1[0, 0]);
        s_1[0, 0] = s_1[0, 0];
        System.Console.WriteLine(vr3);
    }
}
