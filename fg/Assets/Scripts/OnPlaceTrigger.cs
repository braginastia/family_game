using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlaceTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You start move");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("You finish move");
    }

}
