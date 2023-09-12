namespace BasicProgramming;

class Program
{
    static void Main()
    {
        Program program = new Program();

        program.Hello("Fahri", "Hanif");

        int y = 20; // variabel

        const int age = 25;
        string[] names = { "John" };

        Console.WriteLine(names[0]);

        Console.WriteLine(age > 18 ? "Cukup Umur" : "Belum Cukup Umur");

        if (names.Length is > 1 and < 3) {

        }
    }

    /*
     * <summary>Untuk mencetak Hello World!</summary>
     * <param name="name">Nama yang akan dicetak</param>
     * <returns>void</returns>
     */
    void Hello(string firstName, string lastName, int age = 10)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine(firstName);
        Console.WriteLine(lastName);
        Console.WriteLine(MyAge(age));
    }

    static string MyAge(int age)
    {
        switch (age) {
            case 19:
                return "Umur 19";
            case 20:
                return "Umur 20";
            case 21:
                return "Umur 21";
            default:
                return "Umur Tidak Diketahui";
        }
    }
}
