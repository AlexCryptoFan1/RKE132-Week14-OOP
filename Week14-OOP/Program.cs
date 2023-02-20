
Console.WriteLine("Ur dog name");
string myDogName = Console.ReadLine();
Dog myDog = new Dog("GoodBoy");
Dog neighboursDog = new Dog("Good Girl");



Console.WriteLine($" My dogs name is {myDog.Name}.");
Console.WriteLine($"Neighbours dog name is {neighboursDog.Name}");


myDog.Rename("Bad Boy");
Console.WriteLine($"Level Of Hapiness {myDog.LevelOfHapiness}");

myDog.Bark();

while(myDog.LevelOfHapiness !=5)
{
    myDog.Bark();
}    

myDog.WagTail();

class Dog
{
    private string _name;
    private int _levelOfHapiness ;


    //Constructor
    public Dog(string name)
    {
    _name = name;
        _levelOfHapiness = 0;
}
    //getter

    public int LevelOfHapiness
    {
        get { return _levelOfHapiness;}
    }
    public string Name
    {
        get { return _name; }
    }

    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The Dog renamed to {newName}");
    }

    public void Bark()
    {
        Console.WriteLine("Gaf Gaf");
        _levelOfHapiness++;
    }


    public void WagTail()
    {
        Console.WriteLine("Wiggle-Wiggle");
    }


}