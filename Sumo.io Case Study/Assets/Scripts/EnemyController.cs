using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    private Transform Player;
    private float distance;
    public float MoveSpeed;
    public float HowClose;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        distance = Vector3.Distance(Player.position, transform.position);
        if(distance <= HowClose)
        {
            transform.LookAt(Player);
            GetComponent<Rigidbody>().AddForce(transform.forward * MoveSpeed);
        }


    }
}
