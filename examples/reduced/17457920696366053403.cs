// Generated by Fuzzlyn on 2018-06-24 12:30:04
// Seed: 17457920696366053403
// Reduced from 309.4 KiB to 0.2 KiB
// Debug: Outputs 65526
// Release: Outputs 4294967286
public class Program
{
    public static void Main()
    {
        short[] vr8 = new short[]{-10};
        var vr10 = (ushort)(vr8[0] | 2L);
        long vr12 = vr10;
        System.Console.WriteLine(vr12);
    }
}
