using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealthController : MonoBehaviour
{
    public int currentHealth = 3;
    
    public GameManager p ;
    public GameManager c;
    
    public Text canva_puntos;
    public int puntosPorRespuesta=0;
    public GameObject Pregunta;
    // Start is called before the first frame update
    
    private void Awake()
    {
        p = FindObjectOfType<GameManager>();
        c= FindObjectOfType<GameManager>();
        
        //DontDestroyOnLoad(target:this);
       
    }

    void Start()
    {
        ///canva_puntos.text = "puntos: " + p.puntaje;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageEnemy()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            p.puntaje+=1;
            p.conteo+=1;
            
            canva_puntos.text = "puntos: " + p.puntaje;

            if (p.conteo==5)
            {
                Pregunta.SetActive(true);
            }
        }
    }
    
}

