// Generated by Fuzzlyn on 2018-06-20 02:23:56
// Seed: 4407836798146231402
// Reduced from 100.1 KiB to 0.5 KiB
// Debug: Outputs 0
// Release: Outputs 1
struct S0
{
    public bool F3;
    public S0(sbyte f1): this()
    {
    }
}

struct S1
{
    public int F1;
    public S0 F2;
    public S0 F3;
    public int F4;
}

public class Program
{
    static S1 s_5;
    public static void Main()
    {
        s_5.F3 = M27();
        var vr48 = s_5.F1;
        s_5.F1 = s_5.F4;
        S1 vr47 = s_5;
        var vr39 = s_5.F1;
        System.Console.WriteLine(vr39);
        S0[, ] vr32 = new S0[, ]{{new S0(0)}};
    }

    static S0 M27()
    {
        return new S0(0);
    }
}
