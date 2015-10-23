using UnityEngine;
using System.Collections;

public class vitoria : MonoBehaviour {

	public GameObject sWG;
	private ShowWish sW;
	private SpriteRenderer sR;

	// Use this for initialization
	void Start () {
		sW = sWG.gameObject.GetComponent ("ShowWish") as ShowWish;
		sR = this.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (sW.win) {
			this.gameObject.GetComponent<SpriteRenderer>().enabled = true;
			this.GetComponent<Animator> ().SetBool ("isWin", true);
		} else {
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			this.GetComponent<Animator> ().SetBool ("isWin", false);
		}

	}
}

//ximenes e lindo e incrivel 