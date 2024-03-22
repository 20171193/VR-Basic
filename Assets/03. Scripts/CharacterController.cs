using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigid;

    [SerializeField]
    private float movePower;

    [SerializeField]
    private Vector3 inputDir;

    private void FixedUpdate()
    {
        Move();
    }


    private void OnMove(InputValue value)
    {
        inputDir = value.Get<Vector3>();
    }
    private void Move()
    {
        if (inputDir == Vector3.zero) return;

        rigid.AddForce(inputDir * movePower, ForceMode.Force);
    }
}
