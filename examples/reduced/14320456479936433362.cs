// Generated by Fuzzlyn v1.1 on 2018-08-31 13:17:09
// Seed: 14320456479936433362
// Reduced from 14.7 KiB to 0.4 KiB in 00:00:20
// Debug: Outputs 1
// Release: Outputs 0
struct S1
{
    public ulong F0;
    public sbyte F1;
    public ulong F4;
    public S1(ulong f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1 s_2;
    public static void Main()
    {
        var vr3 = new S1(1);
        var vr5 = new S1(0);
        M1(vr3, M1(s_2, vr5));
    }

    static ref S1 M1(S1 arg0, S1 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_2;
    }
}
