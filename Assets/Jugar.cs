using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{

    public AudioSource Erro1;
    public AudioSource Caid1;
    public GameObject Error;
    public GameObject Acierto;


    
    public void play()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        
        SceneManager.LoadScene(1);
        
    }

    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //SceneManager.LoadScene(1);

    }

    public void exit()
    {
        Debug.Log("Salir...");
        SceneManager.LoadScene(1);
    }

    public void acierto(){
        Instantiate(Acierto);
    }
    public void error(){
        Instantiate(Error);
    }

   
}
