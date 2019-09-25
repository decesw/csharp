using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;


public class EventEntry
{
    public string EventName { get; set; }
    public string ConetntID { get; set; }
    public string WorkspaceName { get; set; }

    public string User { get; set; }
    public override string ToString()
    {
        return string.Format("{0} \t\t{1} \t\t{2} \t\t{3}", this.User, this.WorkspaceName, this.EventName, this.ConetntID);
    }
}

public static class EventServiceHelper
{
    public static List<EventEntry> EventList = new List<EventEntry>();

    public static string EventsToString()
    {
        StringBuilder all = new StringBuilder();
        foreach (EventEntry e in EventList)
            all.AppendLine(e.ToString());
        return all.ToString();
    }
}