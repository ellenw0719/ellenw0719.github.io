using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* === INSTRUCTIONS ===

Create a new public AudioSource object

Set the object to the AudioSource slot in Start() 
soundEffect = GetComponent<AudioSource>();  

Upon collision use the built-in function Play() to 
play the sound effect.

*/

public class soundEffects : MonoBehaviour
{

public AudioSource AudioPlayer; 

void Start()
    {
    AudioPlayer = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other){
        AudioPlayer.Play(); 
    }
    
}
