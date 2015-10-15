using UnityEngine;
using System.Collections;

public class PlayerClimb : MonoBehaviour {
	
    public GameObject gatilho;
    public GameObject gatilho2;
    public GameObject gatilho3;
	public GameObject gatilho6;
	public GameObject gatilho7;
	public GameObject garota;
	//public GameObject subir;
	public GameObject mask1;
	public GameObject mask2;
	public GameObject go;
	public GameObject ganesha;

	private warningActivit sb;
	public Player_Mov pm;

    public float speed_x = 4.3f;

	public string action;

	public static bool nS;

	public bool Move;
	public bool ganeshaB;
	public bool arrivedToGatilho7;
	public bool arrivedUp;
    public bool getOut;
    public bool firstTrigger;
    public bool secondTrigger;
    public bool endTrigger;
	public bool goUp = false;
	public bool goDown = false;
	public bool flauta = false;
	public bool inAction = false;

	// Use this for initialization
	void Start () {
		pm = this.GetComponent<Player_Mov>();
		sb = go.GetComponent<warningActivit> ();
		nS = false;
	}

    void OnTriggerEnter2D(Collider2D Find) 
    {
		if (Find.tag == "gatilho" && Move && !goDown) 
			goUp = true;
		if (Find.tag == "gatilho2" && Move && !goUp)
			goDown = true;
        if (Find.tag == "gatilhoSaida")
            getOut = true;
        if (Find.tag == "gatilho9")
            firstTrigger = true;
        if (Find.tag == "gatilho8")
            secondTrigger = true;
        if (Find.tag == "gatilhoFinal")
            endTrigger = true;
    }
	// Update is called once per frame
	void Update () {
        //Debug.Log(action);
        if(Climb.inAction) {
	        switch(action) {
	        
			case "Subir":
				
				mask1.gameObject.SetActive(true);
				mask2.gameObject.SetActive(true);
				if (goUp)
				{
					transform.position = gatilho2.transform.position;
					Move = false;
					goUp = false;
					Climb.inAction = false;
					arrivedUp = true;
					arrivedToGatilho7 = false;
				}

				if(!arrivedToGatilho7 && !arrivedUp) {
					transform.position = Vector3.MoveTowards(transform.position, gatilho7.transform.position, Time.deltaTime * speed_x);
					pm.ray = gatilho7.transform.position;
				}

				if(transform.position == gatilho7.transform.position) arrivedToGatilho7 = true;

				if(arrivedToGatilho7) {
					transform.position = Vector3.MoveTowards(transform.position, gatilho.transform.position , Time.deltaTime * speed_x);
					pm.ray = gatilho.transform.position;
				}
				
				break;

	        	case "Descer":
	        	
					mask2.gameObject.SetActive(true);
					mask1.gameObject.SetActive(true);
					if (goDown)
					{
						transform.position = gatilho.transform.position;
						Move = false;
						goDown = false;
						Climb.inAction = false;
						arrivedUp = false;
						arrivedToGatilho7 = false;
					}

                    if (!goDown && Move) {
                        transform.position = Vector3.MoveTowards(transform.position, gatilho2.transform.position, Time.deltaTime * speed_x);
                        arrivedUp = false;
						pm.ray = gatilho2.transform.position;
                    }
				 
	        		break;
				case "Flauta":

					if (sb.acFlauta){
						flauta = true;
                        this.GetComponent<Animator>().SetBool("toMoveFlauta", true);
					}
                    Move = false;
                    Climb.inAction = false;


					break;
				case "Ganesha":
					
					ganeshaB = true;
					Move = false;
					Climb.inAction = false;
					garota.transform.eulerAngles = new Vector3(0, 0, 0);
					garota.transform.localPosition = new Vector3(-3.50f , -4.80f, 0f);

					break;

	        }
        }
        if (ganeshaB)
        {
            ganesha.transform.position = new Vector3(-6.38f, -4.25f, 0f);
            nS = true;
        }
        
	}
}
