// Generated by Fuzzlyn v1.1 on 2018-08-28 01:57:24
// Seed: 5013825559566743216
// Reduced from 2.0 KiB to 0.6 KiB
// Debug: Outputs 4294943768
// Release: Outputs 42008
class C0
{
    public long F2;
}

class C1
{
    public C0 F1;
    public C1(C0 f1)
    {
        F1 = f1;
    }
}

struct S0
{
    public uint F0;
    public C0 F4;
    public uint F5;
    public C1 F7;
    public ushort F8;
    public S0(uint f0, C1 f7, ushort f8): this()
    {
        F0 = f0;
        F7 = f7;
        F8 = f8;
    }
}

public class Program
{
    public static void Main()
    {
        S0 vr0 = new S0(0, new C1(new C0()), 42008);
        vr0.F5 = (uint)(short)vr0.F8;
        vr0 = new S0(vr0.F5, vr0.F7, (ushort)vr0.F7.F1.F2);
        System.Console.WriteLine(vr0.F0);
    }
}
