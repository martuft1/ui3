using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loginmaster : MonoBehaviour
{
    // Start is called before the first frame update
    //
    public string contraseña = "hola";
    public InputField contra;
  public void BotonAceptar()
    {
        if (contra.text == contraseña)
        {
            Debug.Log("Access Granted");
        }
        else
        {
            Debug.Log("Acces Denied");
        }
    }
}
