public class Program
{
    static Fuzzlyn.Execution.IRuntime s_rt;
    static uint[] s_1 = new uint[]{0};
    static int[][] s_4 = new int[][]{new int[]{0}};
    static bool s_7;
    static sbyte[, ] s_16 = new sbyte[, ]{{0}};
    static short s_19;
    static byte s_25;
    public static void Main(Fuzzlyn.Execution.IRuntime rt)
    {
        s_rt = rt;
        M12(s_16, s_25, s_19);
        uint vr5 = 0;
        byte vr4 = (byte)vr5;
    }

    static void M0()
    {
        ref sbyte[, ] vr7 = ref s_16;
        ref byte vr8 = ref s_25;
        ref short vr9 = ref s_19;
        try
        {
            sbyte[] vr10 = new sbyte[]{0};
        }
        finally
        {
            sbyte vr11 = vr7[0, 0];
            sbyte vr12 = vr7[0, 0];
            s_rt.Checksum("c_28", vr12);
            var vr13 = new int[]{450864205};
            ref uint vr18 = ref s_1[0];
            ref int[] vr19 = ref vr13;
            int vr20 = vr19[0];
            var vr14 = s_4[0];
            ref uint vr21 = ref s_1[0];
            ref int[] vr22 = ref vr14;
            int vr23 = vr22[0];
            s_1[0] = (uint)vr23;
        }

        if (!s_7)
        {
            var vr15 = new int[]{0};
            ref uint vr24 = ref s_1[0];
            ref int[] vr25 = ref vr15;
            int vr26 = vr25[0];
            vr9 = (short)(51431005U | vr26);
            short vr16 = vr9;
            if (vr7[0, 0] > vr16)
            {
                uint vr17 = s_1[0];
                s_rt.Checksum("c_40", vr17);
            }
        }

        s_rt.Checksum("c_264", vr9);
        uint vr6 = 0;
        byte var0 = (byte)vr6;
    }

    static uint M1()
    {
        ref sbyte[, ] vr27 = ref s_16;
        ref byte vr28 = ref s_25;
        ref short vr29 = ref s_19;
        try
        {
            sbyte[] vr30 = new sbyte[]{0};
        }
        finally
        {
            sbyte vr31 = vr27[0, 0];
            sbyte vr32 = vr27[0, 0];
            s_rt.Checksum("c_28", vr32);
            var vr33 = new int[]{450864205};
            ref uint vr38 = ref s_1[0];
            ref int[] vr39 = ref vr33;
            int vr40 = vr39[0];
            var vr34 = s_4[0];
            ref uint vr41 = ref s_1[0];
            ref int[] vr42 = ref vr34;
            int vr43 = vr42[0];
            s_1[0] = (uint)vr43;
        }

        if (!s_7)
        {
            var vr35 = new int[]{0};
            ref uint vr44 = ref s_1[0];
            ref int[] vr45 = ref vr35;
            int vr46 = vr45[0];
            vr29 = (short)(51431005U | vr46);
            short vr36 = vr29;
            if (vr27[0, 0] > vr36)
            {
                uint vr37 = s_1[0];
                s_rt.Checksum("c_40", vr37);
            }
        }

        s_rt.Checksum("c_264", vr29);
        return 0;
    }

    static void M2()
    {
        M11();
    }

    static void M11()
    {
        M12(s_16, s_25, s_19);
    }

    static void M12(sbyte[, ] arg0, byte arg1, short arg2)
    {
        try
        {
            sbyte[] var2 = new sbyte[]{0};
        }
        finally
        {
            sbyte var3 = arg0[0, 0];
            sbyte var4 = arg0[0, 0];
            s_rt.Checksum("c_28", var4);
            var vr2 = new int[]{450864205};
            M13(ref s_1[0], vr2);
            var vr3 = s_4[0];
            s_1[0] = (uint)M13(ref s_1[0], vr3);
        }

        if (!s_7)
        {
            var vr1 = new int[]{0};
            arg2 = (short)(51431005U | M13(ref s_1[0], vr1));
            short var8 = arg2;
            if (arg0[0, 0] > var8)
            {
                uint var11 = s_1[0];
                s_rt.Checksum("c_40", var11);
            }
        }

        s_rt.Checksum("c_264", arg2);
    }

    static int M13(ref uint arg1, int[] arg2)
    {
        return arg2[0];
    }
}