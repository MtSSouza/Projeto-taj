using UnityEngine;
using System.Collections;

public class ShowWish : MonoBehaviour {

	public GameObject balao;
	public PlayerClimb pc;
	public GameObject player;
	public GameObject win;
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
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (pc.ganeshaB) {
            beginPhase.begin = false;
            if (!pc.getOut) {
                Debug.Log("1 if");
                player.transform.position = Vector3.MoveTowards(player.transform.position, gatilhoSaida.transform.position, Time.deltaTime * 4.3f);
            }
            if (pc.getOut && !pc.firstTrigger) {
                Debug.Log("2 if");
                go.SetActive(false);
                cenarioE.SetActive(true);
                cenarioI.SetActive(false);
                player.transform.position = Vector3.MoveTowards(player.transform.position, gatilho9.transform.position, Time.deltaTime * 4.3f);
            }
            if (pc.firstTrigger && !pc.secondTrigger) {
                Debug.Log("3 if");
                player.transform.position = Vector3.MoveTowards(player.transform.position, gatilho8.transform.position, Time.deltaTime * 4.3f);
            }
            if (pc.secondTrigger && pc.endTrigger) {
                Debug.Log("4 if");
                player.transform.position = Vector3.MoveTowards(player.transform.position, gatilhoFinal.transform.position, Time.deltaTime * 4.3f);
            }
            if (pc.endTrigger) {
                Debug.Log("5 if");
                win.SetActive(true);
            }
		}
		if (!pc.ganeshaB) {
			if (col.tag.Equals ("player")) {
				balao.SetActive (true);
			}
		}
	}

	void OnTriggerExit2D(Collider2D col)
	{

		if (col.tag.Equals ("player")) {
			balao.SetActive (false);
		}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
