// Generated by Fuzzlyn v1.1 on 2018-09-20 03:35:40
// Seed: 7700280406659214482
// Reduced from 336.5 KiB to 0.5 KiB in 00:09:43
// Debug: Outputs 18446744073709542793
// Release: Outputs 23945
public class Program
{
    static ulong[] s_72 = new ulong[]{0};
    public static void Main()
    {
        var vr2 = new short[]{0};
        var vr4 = vr2[0];
        M89(vr4);
    }

    static void M89(short arg1)
    {
        arg1 = (short)(47890 - s_72[0]);
        ulong var5 = (ulong)(arg1 / 2);
        System.Console.WriteLine(var5);
        try
        {
            M90();
        }
        finally
        {
            arg1 = arg1++;
        }
    }

    static bool M90()
    {
        return default(bool);
    }
}
