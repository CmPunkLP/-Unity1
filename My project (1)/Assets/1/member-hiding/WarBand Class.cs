using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start () 
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemys();
        Humanoid goblin = new Goblin();
        human.Yell();
        enemy.Yell();
        goblin.Yell();
    }
}
