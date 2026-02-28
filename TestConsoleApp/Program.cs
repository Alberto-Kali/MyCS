// https://github.com/Alberto-Kali/CapeR/releases/tag/1.0.0


// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//static void KKKKKK(int a) // <=== 👀 Censored
// {
//     Console.WriteLine("KKKKKK"); // <=== 👀 Censored
// }

//KKKKKK(1); // <=== 👀 Censored

//List<int> VotesFromLine = line.Split(' ').Cast<int>().ToList(); // <== NO CASTS
//int a = VotesFromLine.Sum(x => x) // <=== HMM 🤔

//string makan = "";
//for (int i = 0; i < ankap.Count; i++)
//{
//    makan += ankap[i].ToString() + " ";
//}



internal class Program
{
    private static void Main(string[] args)
    {
        //string linessd = Console.ReadLine();
        //TrueElection(linessd);

    }

    public static void Method(List<int> ankap)
    {
        System.Console.WriteLine(string.Join(" ",ankap));
    }

    public static bool TrueElection(string line)
    {
        int[] VotesFromLine = line.Split(' ').Select(x => int.Parse(x)).ToArray();
        if (VotesFromLine.Sum(x => x) > VotesFromLine.Length / 2)
        {
            Console.WriteLine("1");
            return true;
        }
        else
        {
            Console.WriteLine("0");
            return false;
        }
    }

    public static bool Election(bool x, bool y, bool z)
    {
        return (x && y) || (x && z) || (y && z);
    }
}