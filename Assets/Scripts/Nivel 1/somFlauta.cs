﻿using UnityEngine;
using System.Collections;

public class somFlauta : MonoBehaviour {

    public GameObject player;
	private ShowButton sB;
	public GameObject aS;
	private PlayerClimb pc;
	public GameObject aC;
    public GameObject avisoCobra;
    private bool desatColi;
	// Use this for initialization
	void Start () {
        desatColi = false;
		pc = GameObject.Find ("player").GetComponent<PlayerClimb> ();
		sB = this.gameObject.GetComponent ("ShowButton") as ShowButton;
	}
	
	// Update is called once per frame
	void Update () {
      //  Debug.Log(aS.audio.isPlaying);
		if (aC.gameObject.activeSelf && pc.flauta) {
            Debug.Log(desatColi);
            aS.audio.enabled = true;
            if (!aS.audio.isPlaying)
            {
                desatColi = true;
            }
		}

        if (aS.audio.isPlaying)
        {
            player.GetComponent<Animator>().SetBool("toPlayFlauta", true);
        }
        else {
            player.GetComponent<Animator>().SetBool("toPlayFlauta", false);
        }

        if (desatColi)
        {
            this.gameObject.SetActive(false);
            avisoCobra.gameObject.SetActive(false);
        }
	}
}
