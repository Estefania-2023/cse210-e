using System;

public class Activity
{
    protected string _date;
    protected int _minutes;
    protected string _name;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public string GetSummary()
    {
        return "";
    }
}