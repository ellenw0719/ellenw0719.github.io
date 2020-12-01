using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerMove : MonoBehaviour
{
    public int lives = 2;
    public TextMeshProUGUI LivesText;
    public bool SantaAbducted = false;

    
    void Start(){
        Debug.Log("Find and Abduct Santa");
        Debug.Log("Avoid Abducting Elves");
        Debug.Log("Use Arrow Keys to Move");
        
        LivesText.text = "Lives:" + lives;
        
        
    }
    
    void Update(){
    
        transform.Translate(Vector3.forward * Time.deltaTime * Input.GetAxis("Vertical")* 25);  
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal")* 25);      
    }
    
    public void OnTriggerEnter(Collider other){
        
        if(other.gameObject.CompareTag("santa")){
            SantaAbducted = true;
            Destroy(other.gameObject);
            Debug.Log("You Abducted Santa! You Win!");
      
        }
        
        
        if(other.gameObject.CompareTag("elf")){
            lives= lives - 1;
            Destroy(other.gameObject);
            Debug.Log("Oh no! You accidentally abducted an elf!");
            
            
            LivesText.text = "Lives: " + lives;
        }
        
        if (lives==0){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                Debug.Log("You Died!");
        }
    }
    
    
}