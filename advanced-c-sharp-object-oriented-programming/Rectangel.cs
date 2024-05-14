
class Rectangel
{
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

