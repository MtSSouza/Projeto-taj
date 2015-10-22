using UnityEngine;
using System.Collections;

public class somCobra : MonoBehaviour {

	private AudioSource aS;
	private TriggerFind cA;
	public GameObject aC;

	// Use this for initialization
	void Start () {
		aS = this.GetComponent<AudioSource> ();
		cA = this.gameObject.GetComponent("TriggerFind") as TriggerFind;

	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (aS.audio.isPlaying);
		if (aC.gameObject.activeSelf == true && cA.canGoUp == true) {
			aS.audio.mute = false;
		} else {
			aS.audio.mute = true;
		}
	}
}
