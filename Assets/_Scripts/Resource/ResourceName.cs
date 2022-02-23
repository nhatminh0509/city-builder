using System;

public class ResourceNameParser
{
    public static ResourceName FromString(string name)
    {
        return (ResourceName)Enum.Parse(typeof(ResourceName), name);
    }
}

public enum ResourceName
{
    noResource = 0,

    //Currency
    silver = 1,
    gold = 2,
    diamond = 3,

    //Material level 1
    water = 1000,
    logwood = 1001,
    ironOre = 1002,

    //Material level 2
    blank = 2001,

}
