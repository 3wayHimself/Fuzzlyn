// Generated by Fuzzlyn v1.1 on 2018-08-08 18:10:29
// Seed: 8160814227097015781
// Reduced from 16.5 KiB to 0.3 KiB
// Debug: Outputs 18446744073709523038
// Release: Outputs 18446744072580206686
class C0
{
    public int F3;
    public long F4;
    public C0(int f3)
    {
        F3 = f3;
    }
}

public class Program
{
    public static void Main()
    {
        C0 vr3 = new C0(-1129344930);
        vr3.F4 = vr3.F3;
        var vr4 = (ulong)(short)vr3.F3;
        System.Console.WriteLine(vr4);
    }
}
