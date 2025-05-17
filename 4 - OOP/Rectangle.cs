namespace OOP;

class Rectangle
{
    //const musi mieć wartość na etapie kompilacji przypisaną od razu przy inicjalazcji 
    public const int NumberOfCorners = 4;

    //readonly musi być przypisana najpóźniej na etapie runtime, więc można ją zadeklerować później np w konstruktorze
    //MOŻNA dac wartość domyślną, i później nadpisać ją w konstruktorze
    public readonly string Color = "BLUE";

// I stąd różnica pomiędzy const a readonly const będzie troszkę jak static bo dla wszystkich instacnji będzię miala tą samą wartość, readonly może mieć inną 
    public Rectangle(string color)
    {
        Color = color;
    }
}