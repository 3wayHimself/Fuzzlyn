// Generated by Fuzzlyn on 2018-07-19 19:33:53
// Seed: 12798073875996579687
// Reduced from 9.4 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    static char[, ][, ] s_1 = new char[, ][, ]{{new char[, ]{{'-'}}}};
    public static void Main()
    {
        var vr8 = 0 % ((0 & s_1[0, 0][0, 0]) | 1);
        char vr9 = s_1[0, 0][0, 0];
    }
}
