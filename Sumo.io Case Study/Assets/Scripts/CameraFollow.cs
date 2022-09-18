using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform Target;
    [SerializeField] private Vector3 Offset;


    private void Start()
    {
        Offset = transform.position - Target.position;

    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, Target.position + Offset, 20 * Time.deltaTime);
    }
}
