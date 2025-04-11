Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);
myDog._levelOfHapiness = 10;

Dog Pipi = new Dog("Pipi");
Pipi._levelOfHapiness = 5;

Console.WriteLine($"{myDog._name} is a first dog. Level of hapiness: {myDog._levelOfHapiness}");
Console.WriteLine($"{Pipi._name} is a second dog. Level of hapiness: {Pipi._levelOfHapiness}");

class Dog {
    public string _name = "Koer";
    public int _levelOfHapiness = 0;


    //constructor
    public Dog(string name) //name - lets the user name the dog
    {
        Console.WriteLine("Kõikvõimas jumal, koer on loodud");
        _name = name;
        _levelOfHapiness = 0;
    }
}