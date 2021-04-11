using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class substate_random_picker : StateMachineBehaviour
{
    public string m_Name;// Idle picker variable
    public float m_Count;// Amount of animations in the substate
    public AnimationCurve pickCurve;// Idle picker curve

    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
        // Split the count to range
        float range = 1f/m_Count;
        // Find a value
        float pick = pickCurve.Evaluate(Random.Range(0f, 1f));
        //Debug.Log("Pick: " + pick);
        // Get the value to pick animation
        float x = pick/range;
        int y =  Mathf.RoundToInt(x);
        // Set the choice
        animator.SetInteger(m_Name, y);

    }
}