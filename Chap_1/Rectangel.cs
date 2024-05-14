
class Rectangel
{
    // Access modifier only public if i used private or protected the it will not change in objet.
    public int width;
    public int height;

    public Rectangel(int w, int h)
    {
        width = w;
        height = h;
    }

    public Rectangel(int side)
    {
        width = height
            = side;
    }

    public int getArea()
    {
        return width * height;
    }
    // properties that allow access to the private data 
    // called "backing field" properties
    public int Width
    {
        get { return width; }
        set { width = value; }
    }
    public int Height
    {
        get { return height; }
        set {

            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("height", "must be >= 0");
            }
            
            height = value; 
        }

    }
    // auto implmeneted properties don't have backing field
    public int BorderSize
    {
        get; set;
    } = 1;

}

