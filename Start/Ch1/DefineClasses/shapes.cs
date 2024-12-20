// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
class Rectangle
{
    // TODO: The constructor accepts parameters used to create the object
    public Rectangle(int w, int h)
    {
        this.width = w;
        this.height = h;
    }

    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle(int s)
    {
        this.width = s;
        this.height = s;
    }


    // TODO: Classes can define methods that return values
    public Double Area()
    {
        return width*height;
    }

    public Double Perimeter()
    {
        return 2*width + 2*height;
    }

    // TODO: member variables hold data
    public int width;
    public int height;
}