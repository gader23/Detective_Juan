using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movimiento : MonoBehaviour {
	public float velocidad= 50f;
	Animator an;
	public Animator pe;
	public Animator pc;
	public Animator pb;
	public Animator phb;
	public Animator ph;
	public Text text;
	public GameObject inicio;
	public GameObject panel;
	bool encontrado;
	bool pausado;
	public ControladorSospechosos c ;
	public static int contador=0;
	// Use this for initialization
	void Start () {
		an = GetComponent<Animator>();
		encontrado = false;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name == "ElecciónFinal" && c.casoNR && inicio.activeSelf) {
			Time.timeScale = 0; 	
			if (Input.GetKeyDown ("e")) {
				Cursor.visible = true;
				SceneManager.LoadScene (7);
			}
		}  
			if (inicio.activeSelf ) {
				Time.timeScale = 0;
				if (Input.GetKeyDown ("e")) {
					inicio.SetActive (false);
				if (SceneManager.GetActiveScene ().name == "Escena1") {
					panel.SetActive (true);
				}
					Time.timeScale = 1;
				}
			}

		if (Input.GetKey ("left")||Input.GetKey ("right") ||Input.GetKey ("up") ||Input.GetKey ("down")||Input.GetKey("w")||Input.GetKey("s")||Input.GetKey("a")||Input.GetKey("d")){
			an.SetBool ("Parado", false);
			panel.SetActive (false);
		} else {

			an.SetBool ("Parado", true);

		}
			

		transform.Translate (Input.GetAxisRaw ("Horizontal") * velocidad * Time.deltaTime, 0f, 0f);
		transform.Translate (0f, 0f, Input.GetAxisRaw ("Vertical") * velocidad * Time.deltaTime);
		if (!MenuInicio.pausado || !inicio.activeSelf) {
			
			float pointer_y = Input.GetAxis ("Mouse X");
			transform.Rotate (0, pointer_y * 5f, 0);
		
		}


	}
	void OnTriggerStay(Collider col)
	{
		if (col.tag == "Muerto") {
			text.text = "Parece que este hombre fue asesinado quien lo hizo  quiso borrar las huellas con el agua, iré a dentro a investigar";
			panel.SetActive (true);
			encontrado = true;
		}
		if (encontrado || SceneManager.GetActiveScene().name!="Escena1") {
			if (col.tag == "PuertaEntrada") {
				text.text = "Pulsa 'E' para abrir la puerta";
				panel.SetActive (true);
				//mostrat texto abrir puerta con la tecla e
				if (Input.GetKeyDown ("e")) {
				
					if (pe.GetBool ("Abierto")) {
						pe.SetBool ("Abierto", false);
					} else {
						pe.SetBool ("Abierto", true);
					}
				}
			}

			if (col.tag == "PuertaCocina") {
				text.text = "Pulsa 'E' para abrir la puerta";
				panel.SetActive (true);
				//mostrat texto abrir puerta con la tecla e
				if (Input.GetKeyDown ("e")) {

					if (pc.GetBool ("Abierto")) {
						pc.SetBool ("Abierto", false);
					} else {
						pc.SetBool ("Abierto", true);
					}
				}
			}
			if (col.tag == "PuertaBano") {
				text.text = "Pulsa 'E' para abrir la puerta";
				panel.SetActive (true);

				if (Input.GetKeyDown ("e")) {

					if (pb.GetBool ("Abierto")) {
						pb.SetBool ("Abierto", false);
					} else {
						pb.SetBool ("Abierto", true);
					}
				}
			}
			if (col.tag == "PuertaHabitaBan") {
				text.text = "Pulsa 'E' para abrir la puerta";
				panel.SetActive (true);
				//mostrat texto abrir puerta con la tecla e
				if (Input.GetKeyDown ("e")) {

					if (phb.GetBool ("Abierto")) {
						phb.SetBool ("Abierto", false);
					} else {
						phb.SetBool ("Abierto", true);
					}
				}
			}

			if (col.tag == "PuertaHabitacion") {
				text.text = "Pulsa 'E' para abrir la puerta";
				panel.SetActive (true);
				//mostrat texto abrir puerta con la tecla e
				if (Input.GetKeyDown ("e")) {

					if (ph.GetBool ("Abierto")) {
						ph.SetBool ("Abierto", false);
					} else {
						ph.SetBool ("Abierto", true);
					}
				}
			}

		} else {
			if (col.tag == "PuertaEntrada") {
				text.text = "Puerta Cerrada";
				panel.SetActive (true);
			} 
		}
		if (SceneManager.GetActiveScene().name == "ElecciónFinal" && !c.casoNR) {
			string culpable=ControladorObjetos.nivel;
			if (col.tag == "2") {
				text.text = "Sospechoso número 1, pulse 'E' si cree que es el culpable";
				panel.SetActive (true);
				if (Input.GetKeyDown ("e")) {
					if (culpable == "Escena2") {
						c.SoltarInocentes (1);
					} else {
						c.msge.text = "Creo que este no es el sospechoso que buscamos";
						c.msge.gameObject.SetActive (true);
					}
				}
			}

			if (col.tag == "3") {
				text.text = "Sospechoso número 2, pulse 'E' si cree que es el culpable";
				panel.SetActive (true);
				if (Input.GetKeyDown ("e")) {
					if (culpable == "Escena3") {
						c.SoltarInocentes (2);
					}else {
						c.msge.text = "Creo que este no es el sospechoso que buscamos";
						c.msge.gameObject.SetActive (true);
					}
				}
			}

			if (col.tag == "4") {
				text.text = "Sospechoso número 3, pulse 'E' si cree que es el culpable";
				panel.SetActive (true);
				if (Input.GetKeyDown ("e")) {
					if (culpable == "Escena4") {
						c.SoltarInocentes (3);
					}else {
						c.msge.text = "Creo que este no es el sospechoso que buscamos";
						c.msge.gameObject.SetActive (true);
					}
				}
			}

			if (col.tag == "5") {
				text.text = "Sospechoso número 4, pulse 'E' si cree que es el culpable";
				panel.SetActive (true);
				if (Input.GetKeyDown ("e")) {
					if (culpable == "Escena5") {
						c.SoltarInocentes (4);
					}else {
						c.msge.text = "Creo que este no es el sospechoso que buscamos";
						c.msge.gameObject.SetActive (true);
					}
				}
			}
		}
	}

	void OnTriggerExit(Collider col){
		panel.SetActive (false);
		c.msge.gameObject.SetActive (false);
	}
}
