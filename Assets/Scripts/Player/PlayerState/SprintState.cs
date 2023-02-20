using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprintState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Je suis en Sprint");
    }
    public override void UpdateState(PlayerStateManager player)
    {
        player.IsFalling();
    }
    public override void OnCollisionEnter(PlayerStateManager player, Collision collision)
    {
          
    }
}
