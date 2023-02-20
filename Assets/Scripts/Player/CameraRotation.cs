using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraRotation : MonoBehaviour
{

    private Controls _controls;
    private const float MouseSensitivity = 50;
    private Vector2 _mouseLook;
    private float _xRotation;
    private Transform _playerbody;

    private void Awake()
    {
        _playerbody = transform.parent;

        _controls = new Controls();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        Look();
    }

    private void Look()
    {
        _mouseLook = _controls.Ingame.Look.ReadValue<Vector2>();

        var mouseX = _mouseLook.x * MouseSensitivity * Time.deltaTime;
        var mouseY = _mouseLook.y * MouseSensitivity * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        
        transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);
        _playerbody.Rotate(Vector3.up * mouseX);

    }

    private void OnEnable()
    {
        _controls.Enable();
    }

    private void OnDisable()
    {
        _controls.Disable();
    }
}
