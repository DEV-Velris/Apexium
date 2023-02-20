using Unity.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{

    public GameObject player;
    private Vector2 _mouseMovement;
    private float _xRotation, _yRotation;
    private const float MouseSensitivity = 40;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        var pos = player.transform.position;

        transform.position = pos;

        _mouseMovement = Mouse.current.delta.ReadValue();

        _xRotation -= _mouseMovement.y * Time.deltaTime * MouseSensitivity;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);

        _yRotation += _mouseMovement.x * Time.deltaTime * MouseSensitivity;
        
        transform.rotation = Quaternion.Euler(_xRotation, _yRotation, 0);
        player.transform.rotation = Quaternion.Euler(0, _yRotation, 0);
    }
}
