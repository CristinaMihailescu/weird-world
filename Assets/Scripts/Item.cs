using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    public List<BaseStat> Stats { get; set; }
    public string ObjectName { get; set; }

    public Item(List<BaseStat> Stats, string ObjectName)
    {
        this.Stats = Stats;
        this.ObjectName = ObjectName;
    }
}
