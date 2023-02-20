using UnityEngine;

public class CrouchState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Je suis en Crouch");
    }

    public override void UpdateState(PlayerStateManager player)
    {
        player.IsFalling();
    }

    public override void OnCollisionEnter(PlayerStateManager player, Collision collision)
    {
        
    }
}
