using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    //public Servidor servidor;
    public InputField usuario;
    public InputField contrasenia;

    public void IniciarSesion()
    {
        //string usr = usuario.text;
        //string cont = contrasenia.text;
        /*string[] datos = new string[2];
        datos[0] = usuario.text;
        datos[1] = contrasenia.text;
         
        StartCoroutine(servidor.ConsumirServicio("login",datos, PosCargar));*/
        //if (usr.Equals("usuario1") && cont.Equals("usuario1"))
        //{
            SceneManager.LoadScene(1);
        //}
        
    }

    /*void PosCargar(){
        switch (servidor.respuesta.codigo){
            case 0:
                puntos.puntaje=servidor.respuesta.codigo;
                SceneManager.LoadScene(1);
                break;
                      
        }
            
    }*/
}
