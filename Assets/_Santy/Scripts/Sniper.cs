using UnityEngine;

public class Sniper : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotpoint;
    public float force;
    [SerializeField] private Transform bulletParent;
    [SerializeField] private Transform cameraTransform;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            var bullet = GameObject.Instantiate(bulletPrefab, shotpoint.transform.position, Quaternion.identity, bulletParent);
            bullet.GetComponent<Rigidbody>().AddForce(-Vector3.forward * force,ForceMode.Impulse);
        }
    }
}