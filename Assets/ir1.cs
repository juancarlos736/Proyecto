using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ir1 : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player"){
           SceneManager.LoadScene(1);
        
        }
       
    }
    
}





