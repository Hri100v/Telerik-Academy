using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

public class Event : IComparable
{
    private DateTime date;
    private string title;
    private string location;

    public Event(DateTime date, string title, string location)
    {
        this.date = date;
        this.title = title;
        this.location = location;
    }

    public int CompareTo(object obj)
    {
        Event other = obj as Event;
        int thisDate = this.date.CompareTo(other.date);
        int thisTitle = this.title.CompareTo(other.title);
        int thisLocation = this.location.CompareTo(other.location);

        if (thisDate == 0)
        {
            if (thisTitle == 0)
            {
                return thisLocation;
            }
            else
            {
                return thisTitle;
            }
        }
        else
        {
            return thisDate;
        }
    }

    public override string ToString()
    {
        StringBuilder toString = new StringBuilder();
        toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
        toString.Append(" | " + this.title);

        if (this.location != null && this.location != string.Empty)
        {
            toString.Append(" | " + this.location);
        }

        return toString.ToString();
    }
}