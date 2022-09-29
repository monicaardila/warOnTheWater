using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonNext : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject activadorPregunta;
    public GameObject Pregunta;
    public int  a;
    void Start()
    {
      
    }

    public void Preguntas()
    {
        Destroy(Pregunta);
        
        activadorPregunta.SetActive(true);
        a = 1;
    }


    // Update is called once per frame
   
}
