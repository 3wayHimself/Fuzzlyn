// Generated by Fuzzlyn v1.1 on 2018-08-09 12:25:17
// Seed: 9243164240449406977
// Reduced from 55.2 KiB to 0.2 KiB
// Debug: Outputs 18446744073709522704
// Release: Outputs 1783533328
public class Program
{
    public static void Main()
    {
        int[] vr15 = new int[]{1783533328};
        vr15[0] = vr15[0];
        ulong vr16 = (ulong)(short)vr15[0];
        System.Console.WriteLine(vr16);
    }
}
