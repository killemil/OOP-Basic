public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double topX;
    private double topY;


    public string Id { get { return this.id; } set { this.id = value; } }
    public double Width { get { return this.width; } set { this.width = value; } }
    public double Height { get { return this.height; } set { this.height = value; } }
    public double TopX { get { return this.topX; } set { this.topX = value; } }
    public double TopY { get { return this.topY; } set { this.topY = value; } }

    public bool IsIntersect(Rectangle rectangle)
    {
        if (rectangle.TopX <= this.topX + this.width &&
            rectangle.TopX + rectangle.width >= this.topX &&
            rectangle.TopY <= this.topY + this.height &&
            rectangle.TopY + rectangle.height >= this.topY)
        {
            return true;
        }
        else if (true)
        {

        }
        return false;
    }
}

