using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EJ02 : MonoBehaviour
{
    string contracorrecta;
    string contrausuario;
    public Text ingresousuario;
    public Text textomsj;
    public GameObject cartelitomsj;

    void Start()
    {
        contracorrecta = "12345";
        cartelitomsj.SetActive(false);
    }

    public void validarcontraseña()
    {
        contrausuario = ingresousuario.text;
        if (contrausuario == contracorrecta)
        {
            Debug.Log("Bienvenido");
            cartelitomsj.SetActive(true);
            textomsj.text = "Bienvenido";

        }
        else
        {
            Debug.Log("Contraseña incorrecta");
            cartelitomsj.SetActive(true);
            textomsj.text = "Contraseña incorreca";
        }
    }
}
