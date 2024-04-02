public enum SeatPreference
{
    Window = 1,
    Aisle
}

public class Passenger
{
    public string FirstName { get; }
    public string LastName { get; }
    public SeatPreference Preference { get; }
    public Seat Seat { get; set; }

    public Passenger(string firstName, string lastName, SeatPreference preference)
    {
        FirstName = firstName;
        LastName = lastName;
        Preference = preference;
        Seat = null;
    }
}
