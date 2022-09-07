using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

        StartCoroutine(servidor.ConsumirServicio("login",datos));
    }
}
