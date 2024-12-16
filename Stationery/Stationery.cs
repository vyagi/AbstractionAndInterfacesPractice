namespace Stationery;

public class BallPen
{
    public void Write(string text) { }
}

public class Pencil
{
    public void Write(string text) { }
}

public class Crayon
{
    public void Write(string text) { }
}

public class StationeryTester
{
    public static void Write(string text, IEnumerable<object> instruments)
    {
        foreach (var instrument in instruments)
        {
            if (instrument is BallPen)
            {
                if (((BallPen)instrument).CanWrite)
                {
                    ((BallPen)instrument).Write(text);
                }
            }
            else if (instrument is Pencil)
            {
                if (((Pencil)instrument).CanWrite)
                {
                    ((Pencil)instrument).Write(text);
                }
            }
            else if (instrument is Crayon)
            {
                if (((Crayon)instrument).CanWrite)
                {
                    ((Pencil)instrument).Write(text);
                }
            }
        }
    }
}