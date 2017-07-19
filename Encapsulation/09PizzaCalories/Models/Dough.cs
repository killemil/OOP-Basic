namespace _09PizzaCalories.Models
{
    using System;

    public class Dough
    {
        private string flourType;
        private string technique;
        private double weight;

        private const int MinWeight = 1;
        private const int MaxWeight = 200;
        public Dough(string flourType, string technique, double weight)
        {
            this.FlourType = flourType;
            this.Technique = technique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string Technique
        {
            get
            {
                return this.technique;
            }
            private set
            {
                if (value.ToLower() != "crispy"
                    && value.ToLower() != "chewy"
                    && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.technique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                this.weight = value;
            }
        }

        public double GetCalories()
        {
            double firstModifier = 1.0;
            double secondModifier = 1.0;

            switch (this.flourType.ToLower())
            {
                case "white":
                    firstModifier = 1.5;
                    break;
                case "wholegrain":
                    firstModifier = 1;
                    break;
            }

            switch (this.technique.ToLower())
            {
                case "crispy":
                    secondModifier = 0.9;
                    break;
                case "chewy":
                    secondModifier = 1.1;
                    break;
                case "homemade":
                    secondModifier = 1.0;
                    break;
            }

            double calories = (2 * this.weight) * firstModifier * secondModifier;
            return calories;
        }
    }
}
