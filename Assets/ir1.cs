using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ir1 : MonoBehaviour
{
   public Text textScore;
   private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player"){
            if(puntos.puntaje == 0){
               puntos.puntaje = puntos.puntaje + 1;
            }
           textScore.text = puntos.puntaje.ToString();
           SceneManager.LoadScene(2);
           
        
        }
       
    }
    
}




