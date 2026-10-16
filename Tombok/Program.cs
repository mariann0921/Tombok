namespace Tombok
{
    internal class Program
    {
        static string[] torpok = new string[7];
        static void TorpokLetrehozasa()
        {
            torpok[0] = "Szundi";
            torpok[1] = "Szende";
            torpok[2] = "Hapci";
            torpok[3] = "Morgo";
            torpok[4] = "Tudor";
            torpok[5] = "Vidor";
            torpok[6] = "Kuka";
        }

        static void TorpokKiirasa()
        {
            Console.WriteLine($"A torpok lista elemeinek a száma: {torpok.Length}");
            for (int i = 0; i < torpok.Length; i++)
            {
                Console.WriteLine(torpok[i]); 
            }
        }

        static void Main(string[] args)
        {
            TorpokLetrehozasa();
            TorpokKiirasa();
        }
    }
}
