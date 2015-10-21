using UnityEngine;
using System.Collections;

public class inicioMenu : MonoBehaviour {

    private SpriteRenderer sR;
    private bool stopMenuAnim;

    // Use this for initialization
	void Start () {
        sR = this.GetComponent<SpriteRenderer>();
        stopMenuAnim = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(sR.sprite.name == "Menu0056")
        {
            stopMenuAnim = true;
        }
        makeMenu();
	}

    void makeMenu() 
    {
        if (stopMenuAnim)
            this.GetComponent<Animator>().SetBool("toStopMenuAnim", true);
        else
            this.GetComponent<Animator>().SetBool("toStopMenuAnim", false);
    }
}
