using UnityEngine;
using System.Collections;

public class flauta : MonoBehaviour {

    public GameObject player;
    private PlayerClimb pc;
	// Use this for initialization
	void Start () {
        //pc = player.GetComponent<PlayerClimb>();
	}
	
	// Update is called once per frame
    void Update()
    {
        pc = player.GetComponent<PlayerClimb>();

        if (pc.flauta)
        {
            this.transform.eulerAngles = new Vector3(0, 0, 90f);
            this.transform.position = new Vector3(player.transform.position.x - 0.5f, player.transform.position.y, player.transform.position.z - 0.1f);
        }
        if (PlayerClimb.nS) this.gameObject.SetActive(false);
    }
}
