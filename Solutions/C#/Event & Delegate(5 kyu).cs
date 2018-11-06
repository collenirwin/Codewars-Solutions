using System;
using System.Collections.Generic;

public class PersonEventArgs : EventArgs
{
    public string Name { get; set; }

    public PersonEventArgs(string name)
    {
        Name = name;
    }
    
    public PersonEventArgs() { }
}

public class Publisher
{
    public delegate void ContactNotifyEventHandler(object sender, PersonEventArgs e);
    public event ContactNotifyEventHandler ContactNotify;

    public void CountMessages(List<string> peopleList)
    {
        var dict = new Dictionary<string, int>();
        
        foreach (string person in peopleList)
        {
            if (!dict.ContainsKey(person))
            {
                dict.Add(person, 1);
            }
            else if (++dict[person] % 3 == 0)
            {
                ContactNotify(this, new PersonEventArgs(person)); // Notify subscribers
            }
        }
    }
}