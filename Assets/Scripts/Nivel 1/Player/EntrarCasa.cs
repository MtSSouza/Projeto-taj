using UnityEngine;
using System.Collections;

public class EntrarCasa : MonoBehaviour {

	private bool inside;
	public GameObject cenarioInterior;
	public GameObject cenarioExterior;
	
	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col) {
		
		if (col.tag == "player") {
			inside = true;
			beginPhase.begin = true;
			col.transform.position = new Vector3(-6.95f, -4.48f, -0.1f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (inside) {
			
			cenarioInterior.SetActive(true);
			cenarioExterior.SetActive(false);
		}
		if (!inside) {
			
			cenarioInterior.SetActive(false);
			cenarioExterior.SetActive(true);
		}
	}
}
