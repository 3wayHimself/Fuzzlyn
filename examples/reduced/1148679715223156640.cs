// Generated by Fuzzlyn v1.1 on 2018-08-10 03:48:00
// Seed: 1148679715223156640
// Reduced from 361.0 KiB to 1.0 KiB
// Debug: Outputs -10
// Release: Outputs 2550
public class Program
{
    static byte[] s_8 = new byte[]{0};
    static short[] s_12 = new short[]{0};
    static uint s_13;
    static sbyte[] s_14 = new sbyte[]{0};
    static ushort s_19;
    static ushort s_24;
    static ushort s_52;
    static byte s_68;
    static byte s_71;
    static ushort s_91;
    static sbyte s_96;
    public static void Main()
    {
        short[] vr333 = new short[]{0};
        short vr334 = vr333[0];
        var vr338 = s_68++;
        var vr374 = s_12[0];
        var vr375 = s_12[0];
        var vr376 = (byte)s_14[0];
        var vr389 = (sbyte)vr375;
        var vr402 = s_8[0];
        M141(s_52, s_13, vr389, vr374, (ushort)M141(s_24, (uint)M141(0, 0, 0, 0, s_91, vr402, M141(s_19, s_91, 0, vr334, 0, vr376, (s_68 * -10))), s_96, 0, s_24, s_71, 0), 0, 0);
    }

    static short M141(ushort arg0, uint arg1, sbyte arg2, short arg3, ushort arg4, byte arg8, int arg9)
    {
        System.Console.WriteLine(arg9);
        return arg3;
    }
}
