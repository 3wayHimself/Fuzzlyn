// Generated by Fuzzlyn v1.1 on 2018-09-21 20:34:36
// Seed: 11194076193479938696
// Reduced from 231.4 KiB to 0.5 KiB in 00:04:20
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public sbyte F0;
    public ulong F1;
    public long F2;
    public S0(ulong f1): this()
    {
        F1 = f1;
    }
}

public class Program
{
    static S0 s_36;
    static S0[] s_37 = new S0[]{new S0(1)};
    public static void Main()
    {
        var vr23 = s_37[0];
        var vr24 = new S0(0);
        M88(s_36, M88(vr23, vr24));
    }

    static ref S0 M88(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F1);
        return ref s_36;
    }
}
