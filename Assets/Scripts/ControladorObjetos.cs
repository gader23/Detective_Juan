using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorObjetos : MonoBehaviour {
	public Text text;
	public GameObject panel;
	public static string nivel;


	// Use this for initialization
	void Start () {
		
	}
	
	void OnTriggerStay(Collider col){
		if (col.tag == "Player") {
			text.text = "Pulsa 'E' para recoger el objeto";
			panel.SetActive (true);
			if (Input.GetKeyDown ("e")) {
				Destroy (this.gameObject);
				movimiento.contador=movimiento.contador+1;
				panel.SetActive (false);
				Debug.Log (movimiento.contador);
				if (movimiento.contador == 4) {
					nivel = SceneManager.GetActiveScene().name;
					SceneManager.LoadScene (6);
				}
			}
		} 
	}
}
