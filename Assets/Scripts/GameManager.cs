using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{	
	public int puntaje;
	public int conteo;
	
    // Start is called before the first frame update
	private void Awake()
    {
       
       DontDestroyOnLoad(target:this);
       
    }
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;	
        
        

	


    }

		
		

    // Update is called once per frame
    void Update()
    {

    }
}
