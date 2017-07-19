public class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.Width = width;
        this.Height = height;
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }



    public override double CalculateArea()
    {
        return this.width * this.height;
    }

    public override double CalculatePerimeter()
    {
        return this.width * 2 + this.height * 2;
    }

    public override string Draw()
    {
        return base.Draw() + "Rectangle";
    }
}
