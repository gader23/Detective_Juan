using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorSospechosos : MonoBehaviour {
	public  Animator s1;
	public  Animator s2;
	public  Animator s3;
	public  Animator s4;
	public AudioSource ms;
	public AudioSource fin;
	public  GameObject panel;
	public bool casoNR;
	public Text msge;

	public  void SoltarInocentes(int s){
		if (s == 1) {
			s2.SetBool ("Inocente", true);
			s3.SetBool ("Inocente", true);
			s4.SetBool ("Inocente", true);
			ms.Stop();
			fin.Play();
			casoNR = true;
			StartCoroutine (UsingYield (20));
		}
		if (s == 2) {
			s1.SetBool ("Inocente", true);
			s3.SetBool ("Inocente", true);
			s4.SetBool ("Inocente", true);
			ms.Stop();
			fin.Play();
			casoNR = true;
			StartCoroutine (UsingYield (20));
		}
		if (s == 3) {
			s1.SetBool ("Inocente", true);
			s2.SetBool ("Inocente", true);
			s4.SetBool ("Inocente", true);
			ms.Stop();
			fin.Play();
			casoNR = true;
			StartCoroutine (UsingYield (20));
		}
		if (s == 4) {
			s1.SetBool ("Inocente", true);
			s2.SetBool ("Inocente", true);
			s3.SetBool ("Inocente", true);
			ms.Stop();
			fin.Play();
			casoNR = true;
			StartCoroutine (UsingYield (20));

		}
	}
	 IEnumerator UsingYield(int s){
		yield return new WaitForSeconds (s);
		panel.SetActive (true);
	}
}
