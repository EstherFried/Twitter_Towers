using Twitter_Towers;

Console.WriteLine("Hi, we are getting started!");

string choice;
do
{
    Console.WriteLine("Menu:");
    Console.WriteLine("To select a rectangle press 1");
    Console.WriteLine("To select a triangle press 2");
    Console.WriteLine("To exit the program press 3");
    Console.WriteLine("Please press your choice");
    choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            getWidthAndHeight("rectangle");
            break;
        case "2":
            getWidthAndHeight("triangle");
            break;
        case "3":
            Console.WriteLine("Logging out...");
            break;
        default:
            Console.WriteLine("Invalid choice, please choose again.");
            break;
    }
}
while (choice != "3");

static void getWidthAndHeight(string shape)
{
    bool success;
    int width = 0, height = 0;
    do
    {
        try
        {
            Console.Write("Enter the width of the " + shape + ", must be greater than or equal to 2\n");
            width = Convert.ToInt32(Console.ReadLine());
            if (width < 2)
                success = false;
            else success = true;
        }
        catch
        {
            success = false;
        }
        if (!success)
            Console.WriteLine("Invalid width.");
    }
    while (!success);

    do
    {
        try
        {
            Console.Write("Enter the height of the " + shape + "\n");
            height = Convert.ToInt32(Console.ReadLine());
            if (height <= 0)
                success = false;
            else success = true;
        }
        catch
        {
            success = false;
        }
        if (!success)
            Console.WriteLine("Invalid width.");
    }
    while (!success);

    if (shape == "rectangle")
    {
        Rectangle r = new(width, height);
        Console.WriteLine(r.getRectangleDetails());
    }
    else
    {
        Triangle t = new(width, height);
        chooseTriangleOptions(t);
    }
}
static void chooseTriangleOptions(Triangle t)
{

    string choose;
    do
    {
        Console.WriteLine("To get the perimeter of the triangle press 1");
        Console.WriteLine("To print the triangle press 2");
        choose = Console.ReadLine();
        switch (choose)
        {
            case "1":
                Console.WriteLine("The perimeter of the triangle is "+t.getPerimeter());
                break;
            case "2":
                Console.WriteLine(t.printTriangle());
                break;
            default:
                Console.WriteLine("Invalid press");
                break;
        }
    }
    while (choose != "1" && choose != "2");

}


