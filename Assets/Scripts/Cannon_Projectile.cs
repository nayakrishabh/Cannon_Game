using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Projectile : MonoBehaviour
{
    public Rigidbody rb;
    public float y, z;
    public float Power;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            rb.AddForce(new Vector3(0, y*Power, z*Power), ForceMode.Impulse);
        }
    }
}
