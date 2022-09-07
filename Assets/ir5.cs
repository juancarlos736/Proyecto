using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ir5 : MonoBehaviour
{
   public Text textScore;
   private void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "Player" && puntos.puntaje > 1){
           if(puntos.puntaje == 4 ){
               puntos.puntaje = puntos.puntaje + 1;
            }
           textScore.text = puntos.puntaje.ToString();
           SceneManager.LoadScene(6);
        
        }
       
    }
    
}





