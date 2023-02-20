using UnityEngine;

public class JumpState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("J'entre en Jump");
        player.rigidBody.AddForce(Vector3.up * 400f, ForceMode.Impulse);
    }
    public override void UpdateState(PlayerStateManager player)
    {
        if (player.IsFalling())
        {
            player.SwitchState(player.FallState);
        }

        if (player.IsMoving())
        {
            var transform = player.transform;
            var value = player.playerInput.actions["Movements"].ReadValue<Vector2>();
            var movement = new Vector2(value.x, value.y);
            
            transform.position += transform.forward * (movement.y * 3f * Time.deltaTime);
            transform.position += transform.right * (movement.x * 3f * Time.deltaTime);
        }
        
    }
    public override void OnCollisionEnter(PlayerStateManager player, Collision collision)
    {
          
    }
}
