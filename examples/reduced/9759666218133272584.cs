// Generated by Fuzzlyn on 2018-07-10 01:09:53
// Seed: 9759666218133272584
// Reduced from 324.1 KiB to 0.3 KiB
// Debug: Outputs 65493
// Release: Outputs 4294967253
public class Program
{
    static sbyte s_57 = -43;
    static sbyte s_90;
    public static void Main()
    {
        s_90 = s_57;
        var vr73 = M155();
        uint vr74 = vr73;
        System.Console.WriteLine(vr74);
    }

    static char M155()
    {
        return (char)(197 | s_90);
    }
}
