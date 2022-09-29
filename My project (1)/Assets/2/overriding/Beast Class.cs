using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beast
{
 public Beast ()
    {
        Debug.Log("1st Beast Constructor Called");
    }
        public virtual void Chop ()
    {
        Debug.Log("The Beast has been chopped.");        
    }

    public virtual void SayHello ()
    {
        Debug.Log("Hello, I am a Beast.");
    }
}
