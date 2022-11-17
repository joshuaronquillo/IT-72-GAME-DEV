using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class TryAgain : MonoBehaviour 
{

void Start ()
{
    
}


void Update ()
{

}

void OnTriggerEnter (Collider other)
    {
     if (other.CompareTag ("Repeat")) 
     {

        SceneManager.LoadScene ("SampleScene");
     }
    }
}