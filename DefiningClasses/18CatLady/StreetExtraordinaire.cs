namespace _18CatLady
{
    public class StreetExtraordinaire : Cat
    {
        private int meowDecibels;

        public int MeowDecibels { get { return this.meowDecibels; } set { this.meowDecibels = value; } }

        public override string ToString()
        {
            return this.GetType().Name + " " + this.Name + " " + this.meowDecibels;
        }
    }
}
