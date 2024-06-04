using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private GameObject fireshoot;
    public Transform inpos;
    public float y, z;
    private float power = 350f;
    private float delay = 4f;
    private GameObject shot;
    private Transform mytransform;
    void Awake() {
        mytransform = transform;
    }

    void Update()
    {
        float scrollinput =  Input.mouseScrollDelta.y;
        float axisrotate = Input.GetAxis("Mouse X");

        if (scrollinput > 0) {
            power += 100;
            if(power > 2500f ) {
                power = 2500f;
            }
            Debug.LogError(power);
        }
        if (scrollinput < 0) {
            power -= 100;
            if (power < 350f) {
                power = 350f;
            }
            Debug.LogError(power);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            OnClickShoot();
            Rigidbody rb = shot.GetComponent<Rigidbody>();
            rb.AddForce(inpos.forward *power, ForceMode.Force);
        }

        if (axisrotate > 0) {
            mytransform.Rotate(0, axisrotate, 0);
        }
        if (axisrotate < 0) {
            mytransform.Rotate(0, axisrotate, 0);
        }


    }
    
    private void OnClickShoot() {

        shot =  Instantiate(fireshoot, inpos.transform.position, inpos.transform.rotation);

        Destroy(shot, delay);
    }
}
