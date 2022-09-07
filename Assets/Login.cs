using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public Servidor servidor;
    public InputField usuario;
    public InputField contrasenia;

    public void IniciarSesion()
    {
        string[] datos = new string[2];
        datos[0] = usuario.text;
        datos[1] = contrasenia.text;

        StartCoroutine(servidor.ConsumirServicio("login",datos, PosCargar));
        
    }

    void PosCargar(){
        switch (servidor.respuesta.codigo){
            case 0:
                puntos.puntaje=servidor.respuesta.codigo;
                SceneManager.LoadScene(1);
                break;
                      
        }
            
    }
}
