using UnityEngine;
using System.Collections;

public class buttonsVoltar : MonoBehaviour {

    void OnMouseDown()
    {
        Application.LoadLevel(0);
        beginPhase.begin = false;
    }
}
