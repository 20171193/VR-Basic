using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private Transform origin;

    [SerializeField]
    private Rigidbody rigid;

    [SerializeField]
    private float movePower;

    [SerializeField]
    private Vector2 inputDir;

    private void FixedUpdate()
    {
        
    }
    private void Update()
    {
        transform.position = origin.position;
    }

    private void OnMove(InputValue value)
    {
        inputDir = value.Get<Vector2>();
    }
    private void Move()
    {
        if (inputDir == Vector2.zero) return;

        Vector3 moveDir = new Vector3(inputDir.x, 0, inputDir.y);
        rigid.AddForce(moveDir * movePower, ForceMode.Force);
    }
}
