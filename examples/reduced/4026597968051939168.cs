// Generated by Fuzzlyn v1.1 on 2018-11-14 04:16:25
// Seed: 4026597968051939168
// Reduced from 220.9 KiB to 0.7 KiB in 00:02:32
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public uint F0;
    public int F1;
    public int F3;
    public ulong F4;
    public S0(uint f0): this()
    {
        F0 = f0;
    }
}

class C0
{
    public short F4;
    public S0 F5;
}

public class Program
{
    static C0 s_4 = new C0();
    public static void Main()
    {
        var vr3 = new S0(0);
        var vr4 = new S0(1);
        bool vr5 = M7(vr3, M16(vr4));
    }

    static bool M7(S0 arg0, S0 arg1)
    {
        System.Console.WriteLine(arg0.F0);
        return false;
    }

    static ref S0 M16(S0 arg0)
    {
        short var0 = s_4.F4;
        System.Console.WriteLine(var0);
        return ref s_4.F5;
    }
}
