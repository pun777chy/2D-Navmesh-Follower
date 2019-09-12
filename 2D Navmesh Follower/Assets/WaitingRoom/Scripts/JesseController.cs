using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JesseController : MonoBehaviour
{
    public Transform target;
    public float offSet;
	private Animator animController;
	public UnityEngine.AI.NavMeshAgent myAgent;
    // Start is called before the first frame update
    void Start()
    {
		animController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		if (myAgent.velocity.x == 0)
		{
			animController.SetInteger("Direction", 0);
		}
		else if(myAgent.velocity.z>0.5f)
		{
			animController.SetInteger("Direction",1);
		}
		else if (myAgent.velocity.z < -0.5f)
		{
			animController.SetInteger("Direction", 2);
		}
		else if (myAgent.velocity.x > 0.5f)
		{
			animController.SetInteger("Direction", 3);
		}
		else if (myAgent.velocity.x < -0.5f)
		{
			animController.SetInteger("Direction", 4);
		}
	}
    void LateUpdate()
    {
        transform.localPosition = new Vector3(target.localPosition.x,transform.localPosition.y,target.localPosition.z+offSet);
    }
}
