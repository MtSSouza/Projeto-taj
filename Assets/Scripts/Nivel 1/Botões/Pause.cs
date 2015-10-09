using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

    public GameObject pause;

    void OnMouseDown() 
    {
        Player_Mov.canMove = false;
        pause.gameObject.SetActive(true);
    }
}
