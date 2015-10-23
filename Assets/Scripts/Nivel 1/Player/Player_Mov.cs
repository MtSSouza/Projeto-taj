using UnityEngine;
using System.Collections;

public class Player_Mov : MonoBehaviour
{
	public GameObject player;

	private PlayerClimb pc;
    public static bool canMove;
    public float speed_x;
    public static bool isMove;

	private Animator animatorMove;
	private AnimatorStateInfo animStateMove;

    Vector3 newPos;
    public Vector3 ray;

    // Use this for initialization
    void Start()
    {
		animatorMove = this.GetComponent<Animator>();
        canMove = true;
        isMove = false;
        speed_x = 4.3597135345f;
        
		pc = player.GetComponent<PlayerClimb> ();
    }

    // Update is called once per frame
    void Update()
    {
		if (beginPhase.begin == true) {
		
			if (ray.x < this.transform.position.x)
				this.transform.eulerAngles = new Vector3 (0f, 180f, 0f);
			if (ray.x > this.transform.position.x)
				this.transform.eulerAngles = new Vector3 (0f, 0f, 0f);
		}
		//Debug.Log (canMove);
		animStateMove = animatorMove.GetCurrentAnimatorStateInfo (0);
		if (beginPhase.begin == true && canMove == true) {
		
			newPos = new Vector3 (transform.localPosition.x, transform.localPosition.y, 0f);
			Vector3 screenPos = Camera.main.WorldToScreenPoint (transform.localPosition);

			Vector3 inputPosition = Input.mousePosition;
			if (Input.GetMouseButtonDown (0)) {
				isMove = true;
				ray = Camera.main.ScreenToWorldPoint (new Vector3 (inputPosition.x, screenPos.y, 9.9f));
			}

			if (isMove) {
				transform.position = Vector3.MoveTowards (transform.position, ray, Time.deltaTime * speed_x);
			}

			if (transform.position == ray || pc.Move)
				isMove = false;

			if (isMove && ray != this.transform.position) {

				animatorMove.SetBool ("toMove", true);
			}
			if (ray == this.transform.position)
				animatorMove.SetBool ("toMove", false);
		}
		if (ray.y < 0) {
		
			if(ray.x < -8f) {
				ray = new Vector3(-8f, ray.y, ray.z);
			}
			if(ray.x > 8.2f) {
				ray = new Vector3(8.2f, ray.y, ray.z);
			}	
		}
		if (ray.y > 0) {

			if(pc.animFlauta) {

				if(ray.x < -8f) {
					ray = new Vector3(-8f, ray.y, ray.z);
				}
			} else {

				if(ray.x < -3.2f) {
					ray = new Vector3(-3.2f, ray.y, ray.z);
				}
			}
			if(ray.x > 8.2f) {
				ray = new Vector3(8.2f, ray.y, ray.z);
			}	
		}
    }
}