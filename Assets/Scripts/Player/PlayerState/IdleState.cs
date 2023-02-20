using UnityEngine;

public class IdleState : PlayerBaseState
{
     public override void EnterState(PlayerStateManager player)
     {
          Debug.Log("Je suis en Idle");
     }
     public override void UpdateState(PlayerStateManager player)
     {

          if (player.IsFalling())
          {
               player.SwitchState(player.FallState);
          }

          if (player.playerInput.actions["Movements"].IsPressed())
          {
               // player.SwitchState(player.WalkingState);
          } else if (player.playerInput.actions["Jump"].IsPressed())
          {
               player.SwitchState(player.JumpState);
          }

     }
     public override void OnCollisionEnter(PlayerStateManager player, Collision collision)
     {
          
     }
}
