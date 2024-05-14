
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
}

