// Generated by Fuzzlyn v1.1 on 2018-08-20 22:30:15
// Seed: 690738195987614770
// Reduced from 146.0 KiB to 0.5 KiB in 00:02:32
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public sbyte F0;
    public ulong F2;
    public long F5;
    public S0(sbyte f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_10 = new S0(1);
    static S0 s_13;
    public static void Main()
    {
        var vr4 = new S0(0);
        M30(s_10, M30(vr4, s_13));
    }

    static ref S0 M30(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_13;
    }
}
