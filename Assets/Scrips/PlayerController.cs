using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController characterController;
    [SerializeField] float baseMoveSpeed = 12f;
    [SerializeField] Transform groundChecker;
    [SerializeField] LayerMask layerMask;
    [SerializeField] float speedDown = 0.5f;
    [SerializeField] float speedUp = 2f;
    float moveSpeed;
    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        RaycastHit hit;
        if (Physics.Raycast(groundChecker.position, transform.TransformDirection(Vector3.down), out hit, 1f, layerMask))
        {
            string terrainType = hit.collider.gameObject.tag;

            switch (terrainType)
            {
                case "LowSpeed":
                    moveSpeed = baseMoveSpeed * speedDown;
                    break;
                case "HighSpeed":
                    moveSpeed = baseMoveSpeed * speedUp;
                    break;
                default:
                    moveSpeed = baseMoveSpeed;
                    break;
            }
        }
        Vector3 forward = Input.GetAxis("Vertical") * Time.deltaTime * transform.forward;
        Vector3 strafe = Input.GetAxis("Horizontal") * Time.deltaTime * transform.right;
        Vector3 move = forward + strafe;
        characterController.Move(move * moveSpeed);
    }
}
