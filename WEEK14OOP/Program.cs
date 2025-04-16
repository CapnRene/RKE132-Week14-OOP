//Cat
Cat newCat = new Cat("Garfield", "ginger");
Console.WriteLine($"{newCat.Name} wants a rub on its belly.");
while (newCat.BellyFull != 0
)
{
    newCat.Sleep();
}
newCat.Meow();
newCat.ShowCatData();

//Dog
Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
myDog.NewHapiness(0);

Dog Pipi = new Dog("Pipi");
Pipi.NewHapiness(5);

Console.WriteLine($"{myDog.Name} is a first dog. Level of hapiness: {myDog.LevelOfHapiness}");
Console.WriteLine($"{Pipi.Name} is a second dog. Level of hapiness: {Pipi.LevelOfHapiness}");

myDog.Rename("Paha Pontu");

myDog.Bark();
Console.WriteLine($"My dogs level of hapiness: {myDog.LevelOfHapiness}");

while (myDog.LevelOfHapiness != 5)
{
    myDog.Bark();
    Console.WriteLine($"My dogs level of hapiness: {myDog.LevelOfHapiness}");
}

myDog.WagTail();

class Dog {
    private string _name = "Koer";
    private int _levelOfHapiness = 0;


    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        Console.WriteLine("Kõikvõimas jumal, koer on loodud");
        _name = name;
        _levelOfHapiness = 0;
    }

    //getter
    public string Name
    {
        get { return _name; }
    }
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    //setter
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"Koera uus nimi on {_name}");
    }

    public void NewHapiness(int newHapiness)
    {
        _levelOfHapiness = newHapiness;
    }

    public void Bark()
    {
        Console.WriteLine("Auh-auh!");
        _levelOfHapiness += 1;
    }

    public void WagTail()
    {
        Console.WriteLine("Koer lehvitab saba");
        _levelOfHapiness += 1;
    }
};



class Cat
{
    private string _name;
    private string _color;
    private int _bellyFull;
    public Cat(string name, string color)
    {
        _name = name;
;
        _color = color;
;
        _bellyFull = 10;
        Console.WriteLine($"A {color} cat {name} has been created.");
    }

    public string Name //getter
    {

        get
        {
            return
             _name;
        }
    }

    public int BellyFull //getter
    {

        get
        {
            return _bellyFull;
        }
    }
    public void Sleep()
    {
        _bellyFull--;
        Console.WriteLine($"{_name} says: Z-z-Z-z-Z-z");
    }
    public void Meow()
    {
        Console.WriteLine($"{_name} says: Meow!");
    }
    public void ShowCatData() //displays info about the cat object
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Color: {_color}");
        Console.WriteLine($"Level of hungriness: {_bellyFull}");
    }

}