// Generated by Fuzzlyn v1.1 on 2018-09-04 16:07:50
// Seed: 11038008548541856974
// Reduced from 346.0 KiB to 0.5 KiB in 00:07:22
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public uint F0;
    public ulong F1;
    public long F2;
    public S0(uint f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_6;
    static S0 s_51 = new S0(1);
    public static void Main()
    {
        S0 vr4 = default(S0);
        var vr3 = new S0(0);
        M56(vr4, M56(s_51, vr3));
    }

    static ref S0 M56(S0 arg0, S0 arg1)
    {
        uint vr5 = arg0.F0;
        System.Console.WriteLine(vr5);
        return ref s_6;
    }
}
