using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class box : MonoBehaviour
{
    Rigidbody rb;
    BoxCollider boxCol;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeAll;
        boxCol = GetComponent<BoxCollider>();
        transform.parent.GetComponent<figure>().action += Action;
    }

    private void Start()
    {
        LvlManager.instanse.ElementCount++;
    }

    private void Action()
    {
        if (rb != null)
        {
            rb.useGravity = true;
            rb.constraints = RigidbodyConstraints.None;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.parent.GetComponent<figure>().action?.Invoke();


            LvlManager.instanse.ElementCount--;
            Destroy(rb);
            Destroy(boxCol);
            transform.parent = collision.gameObject.transform;
        }
    }
}
