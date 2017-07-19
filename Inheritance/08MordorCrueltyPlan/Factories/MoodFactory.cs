namespace _08MordorCrueltyPlan.Factories
{
    using _08MordorCrueltyPlan.Models;
    using _08MordorCrueltyPlan.Models.Moods;

    public class MoodFactory
    {
        public Mood GetMood(int hapinessPoints)
        {
            if (hapinessPoints < -5)
            {
                return new Angry();
            }
            if (hapinessPoints <= 0)
            {
                return new Sad();
            }
            if (hapinessPoints <= 15)
            {
                return new Happy();
            }

            return new JavaScript();
        }
    }
}
