using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
    
    public void play()
    {
        //SceneManagement.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void exit()
    {
        Debug.Log("Salir...");
        //SceneManagement.LoadScene(0);
    }

   
}
