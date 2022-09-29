using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghosts : Monsters 
{
    public Ghosts()
    {
        color = "white ";
        Debug.Log("1st Ghosts Constructor Called");
    }
    public Ghosts(string newColor) : base(newColor)
    {
        Debug.Log("2nd Ghosts Constructor Called");
    }
}
