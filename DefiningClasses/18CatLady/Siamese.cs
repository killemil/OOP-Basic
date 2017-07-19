namespace _18CatLady
{
    public class Siamese : Cat
    {
        private int earSize;
        
        public int EarSzie { get{ return this.earSize;} set { this.earSize = value; } }

        public override string ToString()
        {
            return this.GetType().Name + " " + this.Name + " " + this.earSize;
        }
    }
}
