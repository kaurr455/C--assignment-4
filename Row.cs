using System.Collections.Generic;

public class Row
{
    public int RowNumber { get; }
    public List<Seat> Seats { get; }

    public Row(int rowNumber)
    {
        RowNumber = rowNumber;
        Seats = new List<Seat>();
        for (char label = 'A'; label <= 'D'; label++)
        {
            Seats.Add(new Seat(label));
        }
    }

    public string DisplayRow()
    {
        string rowDisplay = "";
        foreach (var seat in Seats)
        {
            if (seat.Booked)
            {
                rowDisplay += $"{seat.Passenger.FirstName[0]}{seat.Passenger.LastName[0]} ";
            }
            else
            {
                rowDisplay += $"{seat.Label} ";
            }
        }
        return rowDisplay.Trim();
    }
}
