using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diana : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log(other.gameObject.name);
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
