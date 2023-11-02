using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    //Variables 

    //Set off the death counter 
    private void Start()
    {
        StartCoroutine(Death());
    }

    // Update is called once per frame
    void Update()
    {
    }


    //Waits for the timer to end and then Destorys the bullet 
    private IEnumerator Death()
    {
    }
}
