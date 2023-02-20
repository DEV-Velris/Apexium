using UnityEngine;
using UnityEngine.InputSystem;

public class  PlayerStateManager : MonoBehaviour
{

    public PlayerInput playerInput;
    public Rigidbody rigidBody;
    
    PlayerBaseState currentState;

    public IdleState IdleState = new IdleState();
    public JumpState JumpState = new JumpState();
    public SlideState SlideState = new SlideState();
    public SprintState SprintState = new SprintState();
    public WalkingState WalkingState = new WalkingState();
    public FallState FallState = new FallState();

    private void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        currentState = IdleState;
        
        currentState.EnterState(this);
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log(rigidBody.velocity.y);
        currentState.UpdateState(this);
    }

    private void OnCollisionEnter(Collision collision)
    {
        currentState.OnCollisionEnter(this, collision);
    }

    public void SwitchState(PlayerBaseState state)
    {
        currentState = state;
        state.EnterState(this);
    }

    public bool IsFalling()
    {
        return rigidBody.velocity.y < 0;
    }

    public bool IsMoving()
    {
        return playerInput.actions["Movements"].IsPressed();
    }
}
