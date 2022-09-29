using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
   public Monster()
   {
        Debug.Log("1st Monster Constructor Called");
   }
    public void Chop()
    {
        Debug.Log ("The Monster has been chopped");      
    }
    public void SayHolla()
    {
        Debug.Log("Holla, I am a Monster. ");
    }
}
