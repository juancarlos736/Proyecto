using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class iraInicio : MonoBehaviour
{
   public Text textScore;
   public void SetearPuntaje(){
    
           textScore.text = puntos.puntaje.ToString();
    }
    
}





