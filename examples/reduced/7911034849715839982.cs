// Generated by Fuzzlyn v1.1 on 2018-09-12 03:36:21
// Seed: 7911034849715839982
// Reduced from 209.6 KiB to 0.5 KiB in 00:03:49
// Debug: Outputs 0
// Release: Outputs 1
class C1
{
}

struct S0
{
    public ushort F0;
    public ulong F2;
    public C1 F6;
    public S0(ushort f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S0 s_32;
    public static void Main()
    {
        S0 vr2 = new S0(0);
        var vr4 = new S0(1);
        M26(s_32, M26(vr4, vr2));
    }

    static ref S0 M26(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return ref s_32;
    }
}
