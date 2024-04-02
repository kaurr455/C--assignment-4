using System.Collections.Generic;

public class Plane
{
    public List<Row> Rows { get; }

    public Plane()
    {
        Rows = new List<Row>();
        for (int i = 1; i <= 12; i++)
        {
            Rows.Add(new Row(i));
        }
    }

    public void DisplaySeatingChart()
    {
        foreach (var row in Rows)
        {
            Console.WriteLine(row.DisplayRow());
        }
    }
}
