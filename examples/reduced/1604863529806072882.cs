// Generated by Fuzzlyn v1.1 on 2018-08-19 14:49:42
// Seed: 1604863529806072882
// Reduced from 307.5 KiB to 0.4 KiB
// Debug: Outputs 0
// Release: Outputs 190
struct S1
{
    public bool F0;
    public byte F1;
    public bool F2;
}

struct S2
{
    public sbyte F0;
    public S1 F1;
    public ushort F2;
}

public class Program
{
    static S2 s_18;
    public static void Main()
    {
        s_18.F1 = M79();
        System.Console.WriteLine(s_18.F2);
    }

    static S1 M79()
    {
        return new S1();
    }
}
