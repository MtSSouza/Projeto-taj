using UnityEngine;
using System.Collections;

public class TriggerFind : MonoBehaviour
{

    public bool canGoUp;

    // Use this for initialization
    void Start()
    {
		canGoUp = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
		canGoUp = (col.tag == "player");
    }

    void OnTriggerExit2D(Collider2D coli)
    {
		canGoUp = !(coli.tag == "player");
    }
}
