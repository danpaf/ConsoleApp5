namespace ConsoleApp5;
public enum Color
{
    Red,
    Green,
    Blue,
    Yellow,
    Cyan,
    Magenta
}

public class ColorUtility
{
    public static string GetHexCode(Color color)
    {
        switch (color)
        {
            case Color.Red:
                return "#FF0000";
            case Color.Green:
                return "#00FF00";
            case Color.Blue:
                return "#0000FF";
            case Color.Yellow:
                return "#FFFF00";
            case Color.Cyan:
                return "#00FFFF";
            case Color.Magenta:
                return "#FF00FF";
            default:
                return "Unknown";
        }
    }
}
