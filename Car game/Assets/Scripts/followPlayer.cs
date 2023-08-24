using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    void Start()
    {

    }
    public GameObject player;
    private Vector3 offset = new Vector3(0, 4, -9);
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
    