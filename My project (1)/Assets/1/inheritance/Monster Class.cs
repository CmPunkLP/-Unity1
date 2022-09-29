using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monsters
{
    public string color;
    public Monsters()
    {
        color = "green";
        Debug.Log("1st Monsters Constructor Called");
    }
    public Monsters(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Monsters Constructor Called");
    }
    public void Chop()
    {
        Debug.Log("The " + color + " monsters has been chopped.");        
    }
    public void SayHolla()
     {
        Debug.Log("Holla, I am a monsters.");
    }
}
