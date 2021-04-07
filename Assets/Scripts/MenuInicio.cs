using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicio : MonoBehaviour {
	public GameObject pausa;
	public static bool pausado=false;
	void Update(){
		if (Input.GetKeyDown ("escape")) {
			if (Time.timeScale == 1) {    
				Time.timeScale = 0; 	
				pausa.SetActive(true);
				pausado = true;
			} else if (Time.timeScale == 0) {   
				Time.timeScale = 1;  	
				pausa.SetActive(false);
				pausado = false;
			}
		}
	}

	public void EmpezarJuego(){
		SceneManager.LoadScene (1);

	}
	public void FinalizarJuego(){
		Application.Quit ();
	}

	public void Continuar(){
		Time.timeScale = 1;
		pausa.SetActive (false);pausado = false;
	}


}
