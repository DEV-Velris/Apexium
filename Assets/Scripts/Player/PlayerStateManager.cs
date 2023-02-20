using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  PlayerStateManager : MonoBehaviour
{
    PlayerBaseState currentState;

    public IdleState IdleState = new IdleState();
    public JumpState JumpState = new JumpState();
    public SlideState SlideState = new SlideState();
    public SprintState SprintState = new SprintState();
    public WalkingState WalkingState = new WalkingState();
    public FallState FallState = new FallState();
    
    
    // Start is called before the first frame update
    void Start()
    {
        currentState = IdleState;
        
        currentState.EnterState(this);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
