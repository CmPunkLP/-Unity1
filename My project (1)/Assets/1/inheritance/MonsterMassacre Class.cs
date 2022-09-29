using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class massacre : MonoBehaviour
{
    void Start () 
    {
         Debug.Log("Creating the monsters");
        Monsters myMonsters = new Monsters();
        Debug.Log("Creating the ghosts");
        Ghosts myGhosts = new Ghosts();
        myMonsters.SayHolla();
        myMonsters.Chop();
        myGhosts.SayHolla();
        myGhosts.Chop();
         Debug.Log("Creating the monsters");
        myMonsters = new Monsters("grey");
        Debug.Log("Creating the ghosts");
        myGhosts = new Ghosts("green");
         myMonsters.SayHolla();
        myMonsters.Chop();
         myGhosts.SayHolla();
        myGhosts.Chop();

    }
}
