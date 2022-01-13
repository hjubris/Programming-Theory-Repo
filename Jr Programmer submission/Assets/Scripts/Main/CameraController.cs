using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    [SerializeField]
    private Vector3 offset = new Vector3(11, 5, -4);

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
