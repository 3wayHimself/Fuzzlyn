// Generated by Fuzzlyn v1.1 on 2018-09-28 23:40:50
// Seed: 18337030473176101375
// Reduced from 392.3 KiB to 0.6 KiB in 00:12:25
// Debug: Outputs 1
// Release: Outputs 0
struct S0
{
    public ushort F0;
    public long F5;
    public S0(ushort f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public S0 F0;
    public S0 F6;
    public S1(S0 f0): this()
    {
        F0 = f0;
    }
}

struct S2
{
}

public class Program
{
    static S2 s_10;
    public static void Main()
    {
        var vr13 = new S1(new S0(1));
        S1 vr18 = default(S1);
        S2 vr22;
        var vr17 = M58(vr13, M58(vr18, vr22));
    }

    static ref S2 M58(S1 arg0, S2 arg1)
    {
        System.Console.WriteLine(arg0.F0.F0);
        return ref s_10;
    }
}
