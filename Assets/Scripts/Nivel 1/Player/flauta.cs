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
            this.gameObject.SetActive(false);
        }
      
    }
}
