// Generated by Fuzzlyn on 2018-06-30 13:42:17
// Seed: 9645931339422168632
// Reduced from 62.7 KiB to 0.3 KiB
// Debug: Prints 0 line(s)
// Release: Prints 1 line(s)
public class Program
{
    static short s_1 = -32768;
    public static void Main()
    {
        bool vr20 = s_1 == (ushort)(0L | s_1);
        if (vr20)
        {
            var vr21 = new byte[, ]{{0}};
            var vr23 = vr21[0, 0];
            System.Console.WriteLine(vr23);
        }
        else
        {
        }
    }
}
