using System;
class Hero
{
    public string Name;
    public string Sex;
    public string Rase;
    public string Class;
    public Dictionary<string, int> Skills = new Dictionary<string, int>()
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
}

class InRase
{
    
    public string Name;
    public string Ability;                        //суперсособность
    public string Bonus;
    public string Side;
    public Dictionary<string, int> Skills = new Dictionary<string, int>()
    
    {
        {"Сила",0},
        {"Удача",0},
        {"Ловкость",0},
        {"Харизма",0},
        {"Эмпатия",0},
        {"Красноречие",0},
    };
    public InRase(string name, string ability, string bonus, string side, Dictionary<string, int> skills)
    {
        Name =name;
        Ability = ability;
        Bonus = bonus;
        Side = side;
        Skills = skills;

    }

}



class Program
{
    public static InRase[] Rases =
    {
        new InRase("Люди", "Fire", "Intelect", "sw", new Dictionary<string, int>() {
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        } ),
         new InRase("Эльфы", "Fire", "Intelect", "sw", new Dictionary<string, int>() {
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        } ),
        new InRase("Орки", "Fire", "Intelect", "sw", new Dictionary<string, int>() {
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        } ),
        new InRase("Гоблины", "Fire", "Intelect", "sw", new Dictionary<string, int>() {
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        } ),
        new InRase("Гномы", "Fire", "Intelect", "sw", new Dictionary<string, int>() {
            {"Сила",10},
            {"Удача",5},
            {"Ловкость",6},
            {"Харизма",5},
            {"Эмпатия",4},
            {"Красноречие",7}
        } )        
    };
    
    
    
    static void SelectRase(Hero myHero)
    {

        string[] namesRase = { "Люди", "Эльфы", "Гномы", "Орки", "Гоблины" };
        //Rases = new InRase[namesRase.Length];
        //for(int i = 0; i < namesRase.Length; i++)
        //{
        //    Rases[i] = new InRase["Люди","Fire","Sword", ];
        //}
        Console.WriteLine("Выбери свою расу");
        Select(namesRase);
       
        InRase RaseHero = Rases[Convert.ToInt32(Console.ReadLine()) - 1];              
        Console.WriteLine("Вы выбрали Расу " + RaseHero.Name);
        myHero.Rase = RaseHero.Name;
        //myHero.Scills = RaseHero.Skills;
    }

    static void SelectSex(Hero myHero)
    {
        string[] namesSex = { "Женский", "Мужской" };
        Console.WriteLine("Выбери свой пол");
        Select(namesSex);
        string SexHero = namesSex[Convert.ToInt32(Console.ReadLine()) - 1];              
        Console.WriteLine("Вы выбрали пол " + SexHero);
        myHero.Sex = SexHero;
    }

     static void SelectClass(Hero myHero)
    {
        string[] namesClass = { "Воин", "Разбойник", "Маг", "Вор" };
        Console.WriteLine("Выбери свой класс");
        Select(namesClass);
        string ClassHero = namesClass[Convert.ToInt32(Console.ReadLine()) - 1];              
        Console.WriteLine("Вы выбрали класс " + ClassHero);
        myHero.Class = ClassHero;
    }

    static void Select(string[] words)
    {
        for (int i = 0; i < words.Length-1; i++)
        {
            Console.Write(i+1 + " -" + words[i] + ", ");
        }
        Console.Write(words.Length + " - " + words[words.Length - 1] + ".");
        string RaseHero = namesRase[Convert.ToInt32(Console.ReadLine()) - 1];
        Console.WriteLine("");
    }


    static void Main(string[] args)
    {
        Hero myHero = new Hero();
        Console.WriteLine("Как вас зовут?");
        myHero.Name = Console.ReadLine();
        SelectRase(myHero);
        SelectSex(myHero);
        SelectClass(myHero);

        Console.WriteLine("Все наши хар-ки");
        Console.WriteLine("Ваше имя " + myHero.Name);
        Console.WriteLine("Ваш пол " + myHero.Sex);
        Console.WriteLine("Ваша раса " + myHero.Rase);
        Console.WriteLine("Ваш класс " + myHero.Class);
        Console.WriteLine("Сила" + myHero.Skills["Сила"]);
        Console.WriteLine("Удача" + myHero.Skills["Удача"]);
        Console.WriteLine("Ловкость" + myHero.Skills["Ловкость"]);
        Console.WriteLine("Харизма" + myHero.Skills["Харизма"]);
        Console.WriteLine("Эмпатия" + myHero.Skills["Эмпатия"]);
        Console.WriteLine("Красноречие" + myHero.Skills["Красноречие"]);   

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






