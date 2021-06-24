using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    CharacterController controller;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    Vector3 inputDir = Vector3.zero;
    void FixedUpdate()
    {
        inputDir = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, inputDir.y, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        inputDir.y += Physics.gravity.y * Time.deltaTime * Time.deltaTime;

        controller.Move(inputDir);
    }
}
