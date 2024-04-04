using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Projectile : MonoBehaviour
{
     
    public Rigidbody rb;
    public float y, z;
    private float Power = 0f;
    private float scrollspeed = 0.2f;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float scrollinput = 10 * Input.GetAxis("Mouse ScrollWheel");

        if ( scrollinput > 0) {
            Power += scrollinput * scrollspeed;
            Debug.LogError(scrollinput);
        }
        if (scrollinput < 0) {
            Power += scrollinput * scrollspeed;
            Debug.LogError(scrollinput);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            rb.AddForce(new Vector3(0, y*Power, z*Power), ForceMode.Impulse);
        }
    }
}
