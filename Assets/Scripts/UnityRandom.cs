using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityRandom : MonoBehaviour
{
    // UnityEngine.Random

    private void Start()
    {
        Random.InitState(1);
    }

    public void URbutton()
    {
        int n = Random.Range(0, 10);
        Debug.Log(n);
    }
}
