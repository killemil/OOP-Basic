namespace _18CatLady
{
    public class Cymric : Cat
    {
        private double furLength;

        public double FurLength { get { return this.furLength; } set { this.furLength = value; } }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name} {this.furLength:F2}";
        }
    }
}
