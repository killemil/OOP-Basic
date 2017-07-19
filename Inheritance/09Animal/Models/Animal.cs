namespace _09Animal
{
    using System;

    public class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        public virtual string Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                this.gender = value;
            }
        }
        public virtual void ProduceSound()
        {
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}\n{this.Name} {this.Age} {this.Gender}";
        }
    }
}
