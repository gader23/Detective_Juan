using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Objeto : MonoBehaviour {
	public Text text;
	public GameObject panel;
	void OnTriggerStay(Collider col){
		if (col.tag == "Player") {
			text.text = "Pulsa 'E' para interactuar con el objeto";
			panel.SetActive (true);
			if (Input.GetKeyDown ("e")) {
				int scene=Random.Range (2, 5);
				SceneManager.LoadScene (scene);
			}
		} 
	}
}
