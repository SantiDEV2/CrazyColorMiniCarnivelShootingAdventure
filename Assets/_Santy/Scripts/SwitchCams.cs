using UnityEngine;
using Cinemachine;

public class SwitchCams : MonoBehaviour
{
    [SerializeField] private int priorityBoostAmount;
    [SerializeField] private Canvas thirdPersonCanvas;
    [SerializeField] private Canvas aimCanvas;

    private CinemachineVirtualCamera _virtualCamera;

    private void Awake()
    {
        _virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            _virtualCamera.Priority += priorityBoostAmount;
            aimCanvas.enabled = true;
            thirdPersonCanvas.enabled = false;
        }

        if (Input.GetMouseButtonUp(1))
        {
            _virtualCamera.Priority -= priorityBoostAmount;
            aimCanvas.enabled = false;
            thirdPersonCanvas.enabled = true;
        }
    }
}
