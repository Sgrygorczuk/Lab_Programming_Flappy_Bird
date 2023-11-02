using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    //Variables 

    //==================================================================================================================
    // Base Functions 
    //==================================================================================================================

    //Creates the object, if one already has been created in another scene destroy this one and the make a new one 
    private void Awake()
    {
    }

    //==================================================================================================================
    // Data Update Methods 
    //==================================================================================================================

    //If player collected a fruit this will update the value to true
    public void SetScore(int s)
    {
    }

    //Returns the list of collected fruits, used in start of each level and check in the end scene 
    public int GetScore()
    {
    }
}
