using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivillianFindNextTarget : StateMachineBehaviour
{
	CivillianAi civillianAi;
	// OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Debug.Log("seeking next target");
		civillianAi = animator.gameObject.GetComponent<CivillianAi>();
		civillianAi.GetNextPatrolTarget();
	}
}
