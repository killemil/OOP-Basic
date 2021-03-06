﻿
using System;

public class WaterBender : Bender
{
    private double waterClarity;

    public WaterBender(string name, int power,double waterClarity) 
        : base(name, power)
    {
        this.WaterClarity = waterClarity;
    }
    public double WaterClarity
    {
        get { return this.waterClarity; }
        set { this.waterClarity = value; }
    }

    public override double GetPower()
    {
        return (base.Power * this.WaterClarity);
    }

    public override string ToString()
    {
        return $"Water Bender: {base.Name}, Power: {base.Power}, Water Clarity: {this.WaterClarity:f2}";
    }
}

