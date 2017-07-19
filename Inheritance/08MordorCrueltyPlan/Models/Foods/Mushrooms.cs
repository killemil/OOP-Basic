namespace _08MordorCrueltyPlan.Models.Foods
{
    public class Mushrooms : Food
    {
        private const int HapinessPoints = -10;
        public Mushrooms() 
            : base(HapinessPoints)
        {
        }
    }
}
