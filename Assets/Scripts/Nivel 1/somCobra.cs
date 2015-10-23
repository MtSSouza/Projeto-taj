using UnityEngine;
using System.Collections;

public class somCobra : MonoBehaviour {

	private AudioSource aS;
	private TriggerFind cA;
	public GameObject aC;
    public GameObject cobra;
    private SpriteRenderer sR;
	public bool activSomFlauta;
    private bool stopAnim;


	// Use this for initialization
	void Start () {
        sR = cobra.GetComponent<SpriteRenderer>();
		aS = this.GetComponent<AudioSource> ();
		cA = this.gameObject.GetComponent("TriggerFind") as TriggerFind;
		activSomFlauta = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (aC.gameObject.activeSelf == true && cA.canGoUp == true) {
            cobra.GetComponent<Animator>().SetBool("toMoveCobra", true);
            aS.audio.enabled = true;
            if (sR.sprite.name == "Cobra0040") {
                cobra.GetComponent<Animator>().SetBool("toStopCobra", true);
                
            }
		} 
        else {
            cobra.GetComponent<Animator>().SetBool("toMoveCobra", false);
            cobra.GetComponent<Animator>().SetBool("toStopCobra", false);
            aS.audio.enabled = false;
		}
	}
}
