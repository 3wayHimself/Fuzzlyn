// Generated by Fuzzlyn v1.1 on 2018-08-05 13:18:03
// Seed: 1536193811448334183
// Reduced from 22.9 KiB to 0.6 KiB
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public short F0;
    public short F1;
    public long F3;
    public int F4;
    public S0(short f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static ushort s_2;
    static S0 s_3 = new S0(1);
    public static void Main()
    {
        var vr13 = new S0(0);
        var vr14 = new S0(0);
        M7(vr14, M3(M7(s_3, vr13)));
    }

    static ref S0 M3(long arg0)
    {
        ushort vr11 = s_2;
        S0 vr12 = new S0(0);
        return ref s_3;
    }

    static short M7(S0 arg0, S0 arg2)
    {
        System.Console.WriteLine(arg0.F0);
        return arg0.F1;
    }
}
