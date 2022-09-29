using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Beast
{
    public Wolf()
    {
        Debug.Log("1st Wolf Constructor Called");
    }
      public override void Chop ()
    {
        base.Chop();
        Debug.Log("The Wolf has been chopped.");        
    }
     public override void SayHello ()
    {
        base.SayHello();
        Debug.Log("Hello, I am an Wolf.");
    }
}
