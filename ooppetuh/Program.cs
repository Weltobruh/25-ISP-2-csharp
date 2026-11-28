Rect rect = new Rect(100, 200);
rect.Print();
//rect.width = 100;
//rect.height = 200;
//Console.WriteLine(rect.width);
//Console.WriteLine(rect.height);
//Console.WriteLine(rect.Area());
//Console.WriteLine(rect.Perimetr());
//Console.WriteLine(rect.getWidth());
//Console.WriteLine(rect.getHeight());
rect.setWidth(300);
rect.setHeight(400);
rect.Print();
//Console.WriteLine(rect.Area());
//Console.WriteLine(rect.Perimetr());
//Console.WriteLine(rect.getWidth());
//Console.WriteLine(rect.getHeight());
//double area=rect.width*rect.height;
//double perimetr=2*(rect.height+rect.width);
//Console.WriteLine(area);
//Console.WriteLine(perimetr);
class Rect
{
    private double width;
    private double height;
    public double Width
    {
        get
        {
            return width;
        }
        set
        {
            if(value <= 0) Console.WriteLine("ошибОчак");
            else width = value;
        }
    }
    public double Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value <= 0) Console.WriteLine("ошибОчак");
            else height = value;
        }
    }

    public Rect(double _width, double _height)
    {
        this.width = _width;
        this.height = _height;
    }
    private double Area()
    {
        return width * height;
    }
    private double Perimetr()
    {
        return (width + height) * 2;
    }
    private double getWidth()
    {
        return width;
    }
    private double getHeight()
    {
        return height;
    }
    public void setWidth(double _w)
    {
        width = _w;
    }
    public void setHeight(double _h)
    {
        height = _h;
    }
    public void Print()
    {
        Console.WriteLine("Площадь:" + Area());
        Console.WriteLine("Периметр:" + Perimetr());
        Console.WriteLine("Ширина:" + getWidth());
        Console.WriteLine("Высота:" + getHeight());
    }
}