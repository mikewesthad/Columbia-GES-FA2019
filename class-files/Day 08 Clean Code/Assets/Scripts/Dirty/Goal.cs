using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public Text t;
    public int s = 0;

    void OnTriggerEnter(Collider other)
    {
        s += 1;
        t.text = "Score: " + s;
    }
}
