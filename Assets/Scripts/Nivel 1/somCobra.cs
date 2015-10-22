using UnityEngine;
using System.Collections;

public class somCobra : MonoBehaviour {

	private AudioSource aS;
	private TriggerFind cA;
	public GameObject aC;
	public bool activSomFlauta;


	// Use this for initialization
	void Start () {
		aS = this.GetComponent<AudioSource> ();
		cA = this.gameObject.GetComponent("TriggerFind") as TriggerFind;
		activSomFlauta = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (aC.gameObject.activeSelf == true && cA.canGoUp == true) {
            aS.audio.enabled = true;
		} 
        else {
            aS.audio.enabled = false;
		}
	}
}
