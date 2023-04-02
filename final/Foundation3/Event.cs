using System;
public abstract class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
       _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()} at {_time}\nPlace: {_address.AddressToString()}\n";
    }

    public abstract string GetFullDetails();

    public string GetShortDescription()
    {
        return $"{GetType().Name}: {_title} on {_date.ToShortDateString()}";
    }
}