using UnityEngine;

public class FallState : PlayerBaseState
{
    public override void EnterState(PlayerStateManager player)
    {
        Debug.Log("Je suis en Fall");
    }
    public override void UpdateState(PlayerStateManager player)
    {
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
        if (!collision.gameObject.CompareTag("ground"))
        {
            return;
        }

        Debug.Log("Je touche le sol");
        player.SwitchState(player.IdleState);
        
    }
}
