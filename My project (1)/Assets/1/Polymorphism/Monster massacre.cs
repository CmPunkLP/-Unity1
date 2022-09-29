using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstermassacre : MonoBehaviour
{
    void Start ()
    {
         Monster myMonster = new Ghost();

         myMonster.SayHolla();
         myMonster.Chop();

         Ghost myGhost =(Ghost)myMonster;

         myGhost.SayHolla();
         myGhost.Chop();
    }
   
}
