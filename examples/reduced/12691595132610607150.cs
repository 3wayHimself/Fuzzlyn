// Generated by Fuzzlyn v1.1 on 2018-10-01 05:21:09
// Seed: 12691595132610607150
// Reduced from 109.0 KiB to 0.7 KiB in 00:00:57
// Debug: Outputs False
// Release: Outputs True
struct S0
{
    public bool F1;
    public long F4;
    public bool F5;
    public S0(bool f5): this()
    {
        F5 = f5;
    }
}

struct S1
{
}

struct S2
{
    public S0 F0;
    public S2(S0 f0): this()
    {
        F0 = f0;
    }
}

public class Program
{
    static S1[] s_15 = new S1[]{new S1()};
    public static void Main()
    {
        var vr5 = new S2(new S0(false));
        var vr6 = new S2(new S0(true));
        var vr7 = new S1();
        M22(vr5, M22(vr6, vr7));
    }

    static ref S1 M22(S2 arg0, S1 arg1)
    {
        var vr3 = arg0.F0.F5;
        System.Console.WriteLine(vr3);
        return ref s_15[0];
    }
}
