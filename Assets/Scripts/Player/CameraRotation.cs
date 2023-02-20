using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    private Vector2 _mouseMovement;
    private float _xRotation, _yRotation;
    private const float MouseSensitivity = 0.2f;


    // Start is called before the first frame update
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        var mouseX = Mouse.current.delta.x.ReadValue();
        var mouseY = Mouse.current.delta.y.ReadValue();
        _yRotation += mouseX * MouseSensitivity;
        _xRotation -= mouseY * MouseSensitivity;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(0, _yRotation, 0);
        _camera.transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
    }
}
