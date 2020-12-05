using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivillianMoveToNextTarget : StateMachineBehaviour
{
    GameObject containingObject;
    public float targetDistance = 1f;

    CivillianAi civAiController;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        containingObject = animator.gameObject;
        civAiController = animator.gameObject.GetComponent<CivillianAi>();

        civAiController.OnTarget = false;

        civAiController.MoveToTarget();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //check Patrol Target
        if (Vector3.Distance(containingObject.transform.position, civAiController.PatrolTarget.position) <= targetDistance) {
            animator.SetBool("onTarget", true);
        }

        //check player visibility
        if (civAiController.IsPlayerVisible()) {
            animator.SetBool("isPlayerVisible", true);
        } 
    }
}
