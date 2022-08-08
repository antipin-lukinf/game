class Program
{
    static void SelectRase()
    {
        string[] namesRase = { "Люди", "Эльфы", "Гномы", "Орки", "Гоблины" };
        Console.WriteLine("Выбери свою расу");
        Select(namesRase);
        /*for (int i = 0; i < namesRase.Length; i++)
        {
            Console.Write(i+1 + " - " + namesRase[i] + " ");
        }
        Console.Write(namesRase.Length + " - " + namesRase[namesRase.Length - 1] + ".");
        Console.WriteLine(" ");*/
        string RaseHero = namesRase[Convert.ToInt32(Console.ReadLine()) - 1];              
        Console.WriteLine("Вы выбрали Расу " + RaseHero);
    }

    static void SelectSex()
    {
        string[] namesSex = { "Женский", "Мужской" };
        Console.WriteLine("Выбери свой пол");
        Select(namesSex);
        string SexHero = namesSex[Convert.ToInt32(Console.ReadLine()) - 1];              
        Console.WriteLine("Вы выбрали пол " + SexHero);
    }

     static void SelectClass()
    {
        string[] namesClass = { "Воин", "Разбойник", "Маг", "Вор" };
        Console.WriteLine("Выбери свой класс");
        Select(namesClass);
        string ClassHero = namesClass[Convert.ToInt32(Console.ReadLine()) - 1];              
        Console.WriteLine("Вы выбрали класс " + ClassHero);
    }

    static void Select(string[] words)
    {
        for (int i = 0; i < words.Length-1; i++)
        {
            Console.Write(i+1 + " -" + words[i] + ", ");
        }
        Console.Write(words.Length + " - " + words[words.Length - 1] + ".");
        //string RaseHero = namesRase[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("");
    }


    static void Main(string[] args)
    {
        SelectRase();
        SelectSex();
        SelectClass();
    }

}



//static void Main(string[] args)
//{
//тип массива [] название массива
// int[] numbers = new int[4] {}; // пустой массив, из 4 чисел
//int[] nums1 =new int (1,23,4);
// int[] nums3 = {1,23,4};
// for(int i = 0; i < nums3.Length; i++)
// {
//   nums3[i] = 0;
//     Console.WriteLine(num3[i]);
// } РПГ игра






