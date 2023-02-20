using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementsTest : MonoBehaviour
{

    private PlayerInput _playerInput;
    private Rigidbody _rb;
    
    // Start is called before the first frame update
    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (IsMoving())
        {
            var value = _playerInput.actions["Movements"].ReadValue<Vector2>();
            var movement = new Vector2(value.x, value.y);

            transform.position += transform.forward * (movement.y * 5f * Time.deltaTime);
            transform.position += transform.right * (movement.x * 5f * Time.deltaTime);
        }
    }

    private bool IsMoving()
    {
        return _playerInput.actions["Movements"].IsPressed();
    }
}
