using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkingState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Je suis en Walk");
    }
    public override void UpdateState(PlayerStateManager player)
    {
        player.IsFalling();
    }
    public override void OnCollisionEnter(PlayerStateManager player, Collision collision)
    {
          
    }
}
