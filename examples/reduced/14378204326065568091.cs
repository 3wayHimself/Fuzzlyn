// Generated by Fuzzlyn v1.1 on 2018-08-20 05:50:30
// Seed: 14378204326065568091
// Reduced from 51.6 KiB to 0.9 KiB in 00:00:43
// Debug: Outputs 4294967295
// Release: Outputs 4294967045
class C0
{
    public sbyte F2;
    public C0(sbyte f2)
    {
        F2 = f2;
    }
}

class C1
{
    public C0 F2;
    public C1(C0 f2)
    {
        F2 = f2;
    }
}

public class Program
{
    static C1[, ][] s_3 = new C1[, ][]{{new C1[]{new C1(new C0(-1))}}};
    public static void Main()
    {
        C0 vr0 = new C0(1);
        sbyte vr1 = vr0.F2;
        M9(vr1);
    }

    static void M9(sbyte arg0)
    {
        bool var1;
        arg0 = s_3[0, 0][0].F2.F2;
        uint var2 = (uint)(arg0 % -10);
        try
        {
            var1 = true;
        }
        finally
        {
            s_3 = new C1[, ][]{{new C1[]{new C1(new C0(0))}, new C1[]{new C1(new C0(0))}, new C1[]{new C1(new C0(0))}}};
        }

        System.Console.WriteLine(arg0);
        System.Console.WriteLine(var1);
        System.Console.WriteLine(var2);
    }
}
