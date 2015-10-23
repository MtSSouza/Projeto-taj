using UnityEngine;
using System.Collections;

public class vitoria : MonoBehaviour {

	public GameObject sWG;
	private ShowWish sW;
	private SpriteRenderer sR;
	public GameObject acW, acw2, acw3;

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
			acW.gameObject.SetActive(true);
			acw2.gameObject.SetActive(true);
			acw3.gameObject.SetActive(true);
		} else {
			this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
			this.GetComponent<Animator> ().SetBool ("isWin", false);
			acW.gameObject.SetActive(false);
			acw2.gameObject.SetActive(false);
			acw3.gameObject.SetActive(false);
		}

	}
}

//ximenes e lindo e incrivel 