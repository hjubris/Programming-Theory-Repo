using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Rigidbody enemyRb;
    [SerializeField]
    protected GameObject player;
    protected int arenaLimit = 70;
    // protected Vector3 distance;
    protected float atkDistance = 10;
    protected bool isHit = false;

    public int speed;

    protected virtual void Awake()
    {
        enemyRb = GetComponent<Rigidbody>();
    }
    protected virtual void Start()
    {
        player = GameObject.Find("Player");
        Move();
    }
    private void Update()
    {
        if (player.transform.position.x - transform.position.x < atkDistance)
        {
            Attack();
        }
    }

    //they'll move on the X axis 
    protected virtual void Move()
    {
        if (transform.position.x < arenaLimit)
        {
            enemyRb.AddForce(Vector3.right * speed * Time.deltaTime, ForceMode.Acceleration);
        }
    }

    //if the enemy's X position is less or equal to the maximum distance to attack, then attack the player
    protected virtual void Attack()
    {
        if (!isHit)
        {
            Debug.LogWarning("Enemy attacked!");
        }
    }


    //will swap the enemy model with a ragdoll, should be fun
    protected virtual void Fall()
    {

    }
}

