using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beastmassacre : MonoBehaviour
{
    void Start () 
    {
        Wolf myWolf = new Wolf();
        myWolf.SayHello();
        myWolf.Chop();
        myWolf.SayHello();
        myWolf.Chop();    
        Beast myBeast = new Wolf();
        myWolf.SayHello();
        myWolf.Chop();
    }
}