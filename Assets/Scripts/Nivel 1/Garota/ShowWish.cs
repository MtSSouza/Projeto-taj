using UnityEngine;
using System.Collections;

public class ShowWish : MonoBehaviour {

	public GameObject balao;
	public PlayerClimb pc;
	public GameObject player;
	public bool win;
    public GameObject cenarioE;
    public GameObject cenarioI;

    private GameObject gatilhoSaida;
    private GameObject gatilho9;
    private GameObject gatilho8;
    private GameObject gatilhoFinal;

    public GameObject go;

	// Use this for initialization
	void Start () {
		pc = player.GetComponent<PlayerClimb>();
        gatilhoSaida = GameObject.FindGameObjectWithTag("gatilhoSaida");
        gatilho9 = GameObject.FindGameObjectWithTag("gatilho9");
        gatilho8 = GameObject.FindGameObjectWithTag("gatilho8");
        gatilhoFinal = GameObject.FindGameObjectWithTag("gatilhoFinal");
		win = false;
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (pc.ganeshaB) {
            beginPhase.begin = false;
			win = true;
		}
		if (!pc.ganeshaB) {
			if (col.tag.Equals ("player")) {
                balao.SetActive(true);
                this.GetComponent<Animator>().SetBool("toMoveGarota", true);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{

		if (col.tag.Equals ("player")) {
			balao.SetActive (false);
            this.GetComponent<Animator>().SetBool("toMoveGarota", false);
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
