using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ResponderPregunta : MonoBehaviour {
	

	//public Text canva_puntos;
	
	public GameObject activadorPregunta;
	public GameObject Pregunta;


	public static int puntos;

	void Start (){

	}

	public void Preguntas(){

		
		StartCoroutine (res_correcta ());
	}

	IEnumerator res_correcta(){

		
		yield return new WaitForSeconds (0.5f);
		
		
		
	
		//Destroy (Pregunta);
		Pregunta.SetActive(false);
		activadorPregunta.SetActive(true);
		
		
		//Destroy (activadorPregunta);
		//activadorPregunta.GetComponent<Collider> ().enabled = false;

	}

}
