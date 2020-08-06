using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public float force = 500;
    public ForceMode mode = ForceMode.Force;
    public LayerMask mask;
    Vector3 v = Vector3.zero;
    public Joystick j;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        
        Move(new Vector3(j.Horizontal, 0, j.Vertical));
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(v, 2);
    }

    private void Move(Vector3 v)
    {
        rb.AddForceAtPosition(v * force, transform.position + new Vector3(0, 1), mode);
    }
}
