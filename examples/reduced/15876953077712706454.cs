// Generated by Fuzzlyn on 2018-07-09 05:52:13
// Seed: 15876953077712706454
// Reduced from 7.6 KiB to 0.2 KiB
// Debug: Runs successfully
// Release: Throws 'System.NullReferenceException'
public class Program
{
    public static void Main()
    {
        char[][, ] vr9 = new char[][, ]{new char[, ]{{'J'}}};
        var vr10 = (0 % ((0 & vr9[0][0, 0]) | 1)) ^ vr9[0][0, 0];
    }
}
