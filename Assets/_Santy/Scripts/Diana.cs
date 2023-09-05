using System.Collections;
using UnityEngine;

public class Diana : MonoBehaviour
{
    private bool _able;
    private void Start()
    {
        _able = false;
    }

    private void Update()
    {
        if (_able == true)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        StartCoroutine(DisableCoroutine());
    }

    private IEnumerator DisableCoroutine()
    {
        yield return new WaitForSeconds(1f);
        _able = true;
    }
}
