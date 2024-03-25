using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisAndTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Is collision");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Is Trigger");
    }
}
