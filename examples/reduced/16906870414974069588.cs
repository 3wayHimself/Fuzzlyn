// Generated by Fuzzlyn on 2018-06-21 17:36:07
// Seed: 16906870414974069588
// Reduced from 5.0 KiB to 0.8 KiB
// Debug: Outputs 201
// Release: Outputs 0
struct S0
{
    public byte F0;
    public short F5;
    public ulong F6;
    public sbyte F7;
    public ushort F8;
    public S0(byte f0): this()
    {
        F0 = f0;
    }
}

struct S1
{
    public short F0;
}

struct S2
{
    public S0 F2;
    public S1 F4;
    public S2(S0 f2): this()
    {
        F2 = f2;
    }
}

struct S3
{
    public S2 F0;
    public S3(S2 f0): this()
    {
        F0 = f0;
    }
}

struct S5
{
    public byte F0;
    public bool F1;
}

public class Program
{
    public static void Main()
    {
        S5 vr3 = default(S5);
        S3 vr4 = new S3(new S2(new S0(201)));
        vr3.F0 = vr4.F0.F2.F0;
        bool vr5 = vr3.F1;
        if (vr5)
        {
            vr4.F0.F2.F5 = vr4.F0.F4.F0;
        }

        System.Console.WriteLine(vr3.F0);
    }
}
