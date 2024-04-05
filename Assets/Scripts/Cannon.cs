using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private Transform fireshoot;
    public Transform inpos;
    public float y, z;
    private float Power = 0f;
    private float scrollspeed = 0.2f;
    private Transform shot;
    // Start is called before the first frame update
    void Start()
    {
        inpos = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        float scrollinput = 10 * Input.GetAxis("Mouse ScrollWheel");

        if (scrollinput > 0) {
            Power += scrollinput * scrollspeed;
            Debug.LogError(scrollinput);
        }
        if (scrollinput < 0) {
            Power += scrollinput * scrollspeed;
            Debug.LogError(scrollinput);
        }
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            OnClickShoot();
            Rigidbody rb = shot.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0, y * Power, z * Power), ForceMode.Impulse);
        }
    }

    private void OnClickShoot() {
        shot =  Instantiate(fireshoot, inpos.transform.position, inpos.transform.rotation);
    }
}
