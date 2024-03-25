using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Dont touch!");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You walked");
    }
}
