using System.Drawing;

public class Stopwatch
{
    public int Start;
    public int Stop;

    public void Point(int start, int stop)
    {
        this.Start = start;
        this.Stop = stop;
    }
    public int TimeSpend
    {
        get
        {
            var timeSpan = Stop - Start;
            var time = timeSpan;
            return time; 

        }

    }
}