public class Seat
{
    public char Label { get; }
    public bool Booked { get; private set; }
    public Passenger Passenger { get; private set; }

    public Seat(char label)
    {
        Label = label;
        Booked = false;
        Passenger = null;
    }

    public bool IsAvailable()
    {
        return !Booked;
    }

    public void BookSeat(Passenger passenger)
    {
        Passenger = passenger;
        Booked = true;
    }
}
