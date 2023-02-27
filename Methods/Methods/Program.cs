#region Functions, Parameters, Arguments, Params

//int sum(int a, int b, int c = 5) // a, = 5 b -> parameters
//{
//    return a + b;
//}

//void print(string text)
//{
//    if (text.Length == 0)
//    {
//        Console.WriteLine("Bosh gonderildi");
//        return;
//    }

//    Console.WriteLine(text.Length);
//}

//int max(int x, int y)
//{
//    if (x > y)
//    {
//        return x;
//    }

//    return y;
//}

//int number = 89;
//Console.WriteLine(sum(4, 5)); // 5,6 -> Arguments

//print("Orxan");
//Console.WriteLine(max(4, 10));

//print("");

//int sum(int x, params int[] numbers)
//{
//    int result = 0;
//    foreach (int number in numbers)
//    {
//        result += number;
//    }

//    return result + x;
//}

//int[] arr = { 1, 2, 4, 5, 6, 10, 123 };

//Console.WriteLine(sum(1, 2, 4, 5, 6, 10));
#endregion

class Program
{
    public static void Main()
    {
        //Console.WriteLine(Print("Elvin", "Kamilov", 23));

        //Console.WriteLine(Print("Salam", "sagol"));

        Console.WriteLine(CountOfChars("salam", 'a'));
    }

    static int CountOfChars(string word, char character)
    {
        int count = 0;
        foreach (var c in word)
        {
            if(c == character)
            {
                count++;
            }
        }

        return count;
    }

    //static string Print(string a, string b = "test")
    //{
    //    return "optional method";
    //}

    //static string Print(string a, params string[] arr)
    //{
    //    return "params method";
    //}

    //static string Print(string a)
    //{
    //    return "one parameter method";
    //}


    //Method signature -> Method name, parameters count, parameters type
    //static string Print(string name)
    //{
    //    return name;
    //}

    ////static string Print(string name)
    ////{
    ////    return "";
    ////}

    //static string Print(string name, string surname)
    //{
    //    //return name + " " + surname;
    //    return $"{Print(name)} {surname}";
    //}

    //static string Print(string name, string surname, int age)
    //{
    //    return $"{Print(name, surname)} {age}";
    //}
}