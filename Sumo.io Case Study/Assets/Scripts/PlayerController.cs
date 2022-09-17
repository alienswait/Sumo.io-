using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private TouchController touchController;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float MoveSpeed;


    private void Move(Vector3 direction)
    {
        rb.velocity = direction * MoveSpeed * Time.fixedDeltaTime;
    }

    private void Rotation(Vector3 rotation)
    {
        transform.rotation = Quaternion.LookRotation(rotation, Vector3.up);
    }


    private void FixedUpdate()
    {
        var direction = new Vector3(touchController.Direction.x, y: 0, z: touchController.Direction.y);
        var rotation = new Vector3(touchController.Rotation.x, y: 0, z: touchController.Rotation.y);
        Move(direction);
        Rotation(rotation);
    }

}
