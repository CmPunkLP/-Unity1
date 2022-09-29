using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour
{
  public static int playersCount = 0;

    void Start()
    {
        playersCount++;
    }
}
