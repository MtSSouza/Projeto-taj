
using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    public GameObject pause;
	public bool pauseAnim;
	public GameObject exPause;
	private exitPause exP;
	private SpriteRenderer sR;

	void Start () {
		exP = exPause.gameObject.GetComponent("exitPause") as exitPause;
		sR = pause.GetComponent<SpriteRenderer> ();
	}

    void OnMouseDown() 
    {
		pauseAnim = true;
		exP.stopPauseAnim = false;
		Player_Mov.canMove = false;
    }

	void Update(){
		if (pauseAnim) {
			pause.gameObject.SetActive(true);
		}
	}
}
