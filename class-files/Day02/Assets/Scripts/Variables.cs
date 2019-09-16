using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double taxFaction = 0.07;
        Debug.Log("The tax amount is: " + taxFaction);

        float movementSpeed = 10.5f;
        Debug.Log("The player's movement speed is: " + movementSpeed);

        int health = 98;
        Debug.Log("The player's health is: " + health);

        string warningMessage = "You are too close to the bomb!";
        Debug.Log(warningMessage);

        float average = (10 + 5 + 7) / 3f;
        Debug.Log("Player's average score: " + average);

        Debug.Log(7 / 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
