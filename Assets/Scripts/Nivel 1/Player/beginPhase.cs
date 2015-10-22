using UnityEngine;
using System.Collections;

public class beginPhase : MonoBehaviour {

	public static bool begin;
	public GameObject gatilho8;
	public GameObject gatilho9;
	public GameObject gatilho10;

	private Player_Mov pm;

	public bool arrivedToGatilho8;
	public bool arrivedToGatilho9;
    public bool stopAnimation;

	void Start() {
		
		pm = this.GetComponent<Player_Mov>();
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        stopAnimation = (col.tag == "gatilho9");
    }

	void Update () {

		if (!begin && !arrivedToGatilho8) {
			transform.position = Vector3.MoveTowards (transform.position, gatilho8.transform.position, Time.deltaTime * 4.3597135345f);
            this.GetComponent<Animator>().SetBool("toMove", true);
			pm.ray = gatilho8.transform.position;
		}

        if (!begin && !arrivedToGatilho8 && transform.position == gatilho8.transform.position)
        {
           
            arrivedToGatilho8 = true;
        }
		
		if (!begin && arrivedToGatilho8 && !arrivedToGatilho9) {
			transform.position = Vector3.MoveTowards (transform.position, gatilho9.transform.position, Time.deltaTime * 4.3597135345f);
            this.GetComponent<Animator>().SetBool("toMove", true);
			pm.ray = gatilho9.transform.position;
		}

        if (!begin && !arrivedToGatilho9 && transform.position == gatilho9.transform.position){
            arrivedToGatilho9 = true;
            
        }
		
		if (!begin && arrivedToGatilho9) {
			transform.position = Vector3.MoveTowards (transform.position, gatilho10.transform.position, Time.deltaTime * 4.3597135345f);
            
			pm.ray = gatilho10.transform.position;
		}
        if (stopAnimation)
        {
            this.GetComponent<Animator>().SetBool("toMove", false);
        }

	}
}
