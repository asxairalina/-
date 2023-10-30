
using System;
using System.Diagnostics;

List<database> list = new List<database>();
bool program = true;



while(program){
    string answer = Console.ReadLine();
    if (answer == "exit")
    {
        program = false;
    }
    if (answer == "Start")
    {
        double index;
        string fullName= Console.ReadLine();
        string wm = Console.ReadLine();
        int birthday = Convert.ToInt32(Console.ReadLine());
        int wight = Convert.ToInt32(Console.ReadLine());
        int hight = Convert.ToInt32(Console.ReadLine());
        database Person = new database( fullName,  wm, birthday,  wight,  hight);
        Console.WriteLine( index = wight / (hight * hight));
    }
    
}

class database
{
    //Публичные поля
    public string fullName;
    public string wm;
    public int birthday;
    public int wight;
    public int hight;

    //Конструктор
    public database(string fullName, string wm, int birthday,
        int wight, int hight)
    {
        this.fullName = fullName;
        this.wm = wm;
        this.birthday = birthday;
        this.wight = wight;
        this.hight = hight;
    }

    public void Print()
    {
        Console.WriteLine($"{fullName} {wm} {birthday} {wight} {hight}");
    }


}
