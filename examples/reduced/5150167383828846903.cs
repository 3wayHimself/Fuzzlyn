// Generated by Fuzzlyn on 2018-07-16 02:30:05
// Seed: 5150167383828846903
// Reduced from 2.4 KiB to 0.3 KiB
// Debug: Outputs 65415
// Release: Outputs -121
class C0
{
    public sbyte F2;
    public C0(sbyte f2)
    {
        F2 = f2;
    }
}

public class Program
{
    public static void Main()
    {
        char vr2 = (char)M1();
        System.Console.WriteLine((int)vr2);
    }

    static ushort M1()
    {
        C0 var0 = new C0(-121);
        return (ushort)(0 ^ var0.F2);
    }
}
