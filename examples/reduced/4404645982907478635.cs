// Generated by Fuzzlyn on 2018-07-22 13:55:40
// Seed: 4404645982907478635
// Reduced from 1.6 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.DivideByZeroException'
public class Program
{
    public static void Main()
    {
        byte[] vr0 = new byte[]{1};
        char vr1 = (char)((25 % (-123 ^ vr0[0])) - (byte)(0 % vr0[0]));
        System.Console.WriteLine((int)vr1);
    }
}
