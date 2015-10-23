using UnityEngine;
using System.Collections;

public class exitPause : MonoBehaviour {
	
    public GameObject pause;
	public bool stopPauseAnim;
	public GameObject Pause;
	private Pause P;
		
	void Start () {
		P = Pause.gameObject.GetComponent("Pause") as Pause;;
	}

    void OnMouseDown() {

		stopPauseAnim = true;
		P.pauseAnim = false;
		Player_Mov.canMove = true;
    }
	void Update(){
		if (stopPauseAnim) {
			pause.gameObject.SetActive (false);

			//P.pauseAnim = false;
		}
	}
}
