/ Main method
public class Program
{
    public static void Main(string[] args)
    {
        // Inheritance and Method Overriding
        Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        animal.MakeSound(); // Output: Some generic sound
        dog.MakeSound(); // Output: Bark
        cat.MakeSound(); // Output: Meow

        // Abstract Classes and Methods
        Shape circle = new Circle(5.0);
        Shape rectangle = new Rectangle(4.0, 6.0);

        Console.WriteLine($"Circle area: {circle.GetArea()}"); // Output: Circle area: 78.53981633974483
        Console.WriteLine($"Rectangle area: {rectangle.GetArea()}"); // Output: Rectangle area: 24

        // Interfaces
        IMovable carInstance = new Car();
        IMovable bicycleInstance = new Bicycle();

        carInstance.Move(); // Output: Car is moving
        bicycleInstance.Move(); // Output: Bicycle is moving
    }
}