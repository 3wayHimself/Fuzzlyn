// Generated by Fuzzlyn on 2018-06-25 03:27:09
// Seed: 16013729343052537093
// Reduced from 7.2 KiB to 0.3 KiB
// Debug: Outputs -163857450600557
// Release: Outputs -2147488271
public class Program
{
    static long s_1 = -9223372036854775808L;
    public static void Main()
    {
        var vr7 = new short[][]{new short[]{-9248}};
        char vr19 = (char)(1U ^ vr7[0][0]);
        var vr8 = s_1 / vr19;
        System.Console.WriteLine(vr8);
    }
}
