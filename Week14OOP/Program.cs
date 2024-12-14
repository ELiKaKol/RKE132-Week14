
        Console.WriteLine("Name your dog:");
        string myDogName = Console.ReadLine();
        Dog myDog = new Dog(myDogName);

        Dog neighboursDog = new Dog("Good Girl");

        Console.WriteLine($"My dog's name is {myDog.Name}.");
        Console.WriteLine($"My neighbour's dog's name is {neighboursDog.Name}.");

        myDog.Rename("Bad Boy");

        while (myDog.LevelOfHapiness != 5)
        {
            myDog.Bark();
        }

        myDog.WagTail();
  

class Dog
{
    private string _name; // field
    private int _levelOfHapiness; // field

    // Constructor
    public Dog(string name) // name - lets the user name the dog
    {
        _name = name;
        _levelOfHapiness = 0;
    }

    // Getter for name
    public string Name
    {
        get { return _name; }
    }

    // Getter for level of happiness
    public int LevelOfHapiness
    {
        get { return _levelOfHapiness; }
    }

    // Method to rename the dog
    public void Rename(string newName)
    {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    // Method for barking
    public void Bark()
    {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    // Method for wagging tail
    public void WagTail()
    {
        Console.WriteLine("Wiggle-wiggle!");
    }
}

