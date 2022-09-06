using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
    
    public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        //SceneManager.LoadScene(0);
    }

    public void exit()
    {
        Debug.Log("Salir...");
        SceneManager.LoadScene(0);
    }

   
}
