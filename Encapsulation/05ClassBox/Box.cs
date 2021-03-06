﻿namespace _05ClassBox
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }


        public double GetVolume()
        {
            double volume = this.length * this.width * this.height;
            return volume;
        }

        public double GetLateralSurfaceArea()
        {
            double area = (2 * this.length * this.height) + (2 * this.width * this.height);
            return area;
        }

        public double SurfaceArea()
        {
            double area = (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
            return area;
        }
    }
}
