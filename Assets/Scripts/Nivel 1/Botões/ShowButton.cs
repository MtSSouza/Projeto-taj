using UnityEngine;
using System.Collections;

public class ShowButton : MonoBehaviour {

    public GameObject button;
	private TriggerFind componentActivator;
	private PlayerClimb pc;
	private warningActivit wa;


	public bool flipImage = false;

	// Use this for initialization
	void Start () {
		componentActivator = this.gameObject.GetComponent("TriggerFind") as TriggerFind;

		pc = GameObject.Find ("player").GetComponent<PlayerClimb> ();
		wa = GameObject.Find ("avisoCobra").GetComponent<warningActivit> ();
		/*if(flipImage)
			button.transform.Rotate (Vector3.right);*/

	}


	// Update is called once per frame
	void Update () {

		if (componentActivator.canGoUp)
		{
			//Debug.Log(this.transform.name);
			// se for btnFlauta so ativa se o player nao tiver ja com ela
			if((this.transform.name == "flauta" && pc.flauta) || (this.transform.name == "Ganesha" && pc.ganeshaB)) {
				button.gameObject.SetActive(false);
			} else if (this.transform.name == "flauta" && !wa.acFlauta){
				button.gameObject.SetActive(false);
			} else {
				button.gameObject.SetActive(true);
			}
				
		}
		
		if (!componentActivator.canGoUp) 
		{
			button.gameObject.SetActive(false);
		}
		//Debug.Log (acFlauta);
		if (button.name == "gameover") {
			if(pc.flauta) {
				this.gameObject.SetActive(false);
			}
		}

	}
}
