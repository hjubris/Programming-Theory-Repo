using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Rigidbody PlayerRb;
    [SerializeField]
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            PlayerRb.AddForce(Vector3.left*speed*Time.deltaTime, ForceMode.Impulse);
        }
    }
}
