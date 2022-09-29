using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Monster
{
    public Ghost()
    {
        Debug.Log ("1st apple Constructor Called");
    }
    public new void Chop()
    {
        Debug.Log ("The ghost has been chopped.");
    }
    public new void SayHolla()
    {
        Debug.Log ("Holla, I am Ghost");
    }
}
    
    
