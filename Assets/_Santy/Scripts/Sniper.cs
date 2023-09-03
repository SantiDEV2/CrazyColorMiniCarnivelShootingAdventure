using System;
using UnityEngine;
using Cinemachine;

public class Sniper : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotpoint;
    public float force;
    [SerializeField] private Transform cameraTransform;

    private void Update()
    {
        this.gameObject.transform.rotation = cameraTransform.rotation;
        
        if (Input.GetMouseButtonDown(0))
        {   
            var bullet = GameObject.Instantiate(bulletPrefab, shotpoint.transform.position, cameraTransform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(-shotpoint.forward * force,ForceMode.Impulse);
        }
    }
}