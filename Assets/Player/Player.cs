using System.Collections;

using System.Collections.Generic;

using UnityEngine;


public class Player : MonoBehaviour

{

private Rigidbody _rigidBody;

[SerializeField]

public float _speed;

[SerializeField]

private Transform _camera;

private void Awake()

{

_rigidBody = GetComponent<Rigidbody>();

}

private void HideAndLockCursor()

{

Cursor.lockState = CursorLockMode.Locked;

Cursor.visible = false;

}


private void Update()

{

float horizontal = Input.GetAxis("Horizontal");

float vertical = Input.GetAxis("Vertical");


Vector3 horizontalDirection = horizontal * _camera.right;

Vector3 verticalDirection = vertical * _camera.forward;

verticalDirection.y = 0;

horizontalDirection.y = 0;


Vector3 movementDirection = horizontalDirection + verticalDirection;

_rigidBody.linearVelocity = movementDirection * _speed * Time.fixedDeltaTime;

}

}