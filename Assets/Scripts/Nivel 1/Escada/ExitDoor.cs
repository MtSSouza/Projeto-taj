using UnityEngine;
using System.Collections;

public class ExitDoor : MonoBehaviour {

    public GameObject gatilhoGO;
	public GameObject gatilhoGO2;
	public GameObject gatilhoGO3;
	public GameObject gatilhoGO5;

    public GameObject mask1;
    public GameObject mask2;

	private PlayerClimb pc;

	public bool gatilho = false;
    public bool gatilho2 = false;
    public bool gatilho3 = false;
	public bool gatilho5 = false;

    public float speed_x = 4.3f;

	// Use this for initialization
	void Start () {
		pc = this.gameObject.GetComponent<PlayerClimb>();
	}
	
    void OnTriggerEnter2D(Collider2D col)
    {
		if (col.tag == "gatilho") gatilho = true;
		if (col.tag == "gatilho2") gatilho2 = true;
		if (col.tag == "gatilho3") gatilho3 = true;
		if (col.tag == "gatilho5") gatilho5 = true;
    }

	// Update is called once per frame
	void Update () {

		switch (pc.action) {
		
		case "Subir":

			if (gatilho2) {
				transform.position = Vector3.MoveTowards(transform.position, gatilhoGO3.transform.position, Time.deltaTime * speed_x);
                this.GetComponent<Animator>().SetBool("toMove", true);
				pc.pm.ray = gatilhoGO3.transform.position;
			}
	        if (gatilho3)
	        {
                gatilho = false;
	            gatilho2 = false;
				mask1.gameObject.SetActive(false);
	            mask2.gameObject.SetActive(false);
				gatilho3 = false;
                gatilho5 = false;
				pc.action = "";
                this.GetComponent<Animator>().SetBool("toMove", false);
				Player_Mov.canMove = true;
	        }
			break;
		case "Descer":


			if (gatilho) 
			{
				transform.position = Vector3.MoveTowards(transform.position, gatilhoGO5.transform.position, Time.deltaTime * speed_x);
                this.GetComponent<Animator>().SetBool("toMove", true);
				pc.pm.ray = gatilhoGO5.transform.position;
			}
			if (gatilho5)
			{
                gatilho3 = false;
				gatilho2 = false;
				gatilho = false;
				mask1.gameObject.SetActive(false);
				mask2.gameObject.SetActive(false);
				gatilho5 = false;
				pc.action = "";
                this.GetComponent<Animator>().SetBool("toMove", false);
				Player_Mov.canMove = true;
			}
			break;

		}

	}
}
