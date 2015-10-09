using UnityEngine;
using System.Collections;

public class exitPause : MonoBehaviour {
    public GameObject pause;
    void OnMouseDown() {

        Player_Mov.canMove = true;
        pause.gameObject.SetActive(false);

    }
}
