using System;

class Color
{
    private int red;
    private int green;
    private int blue;   
    public int Red
    {
        get { return red; }
        set { red = NormalizeColorValue(value); }
    }
    public int Green
    {
        get { return green; }
        set { green = NormalizeColorValue(value); }
    }
    public int Blue
    {
        get { return blue; }
        set { blue = NormalizeColorValue(value); }
    }

    public Color(int red, int green, int blue)
    {
        Red = red;
        Green = green;
        Blue = blue;
    }
    public Color() { }

    private int NormalizeColorValue(int colorValue)
    {
        if (colorValue > 255)
        {
            return 255;
        }
        if (colorValue < 0)
        {
            return 0;
        }
        return colorValue;
    }


    public void DisplayColor()
    {
        Console.WriteLine($"{red}, {green}, {blue}");
    }
}
class Program
{
    static void Main()
    {
        Color yellow = new Color(300,300,0);
        yellow.DisplayColor();

        Color ping = new Color();
        ping.Red = 255;
        ping.Green = -20;
        ping.Blue = 147;

        ping.DisplayColor();
    }
}