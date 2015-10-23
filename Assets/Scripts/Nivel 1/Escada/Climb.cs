using UnityEngine;
using System.Collections;

public class Climb : MonoBehaviour {

    public GameObject playerLoc;
    public GameObject pointToGo;

	private Player_Mov pm;
	private PlayerClimb pc;

    public static bool inAction = false;


	// Use this for initialization
	void Start () {
		pm = playerLoc.GetComponent<Player_Mov>();
		pc = playerLoc.GetComponent<PlayerClimb>();
		pc.Move = false;
	}

    void OnMouseDown()
    {
    	inAction = true;
		pc.action = pointToGo.name;
        pc.Move = true;
		Player_Mov.canMove = false;
    }

}
