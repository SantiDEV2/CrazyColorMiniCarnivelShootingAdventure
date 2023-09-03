using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _playerVelocity;
    private bool _groundedPlayer;
    
    [SerializeField]
    private float _playerSpeed = 2.0f;
    [SerializeField]
    private float _gravityValue = -9.81f;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        _groundedPlayer = _controller.isGrounded;
        if (_groundedPlayer && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * (Time.deltaTime * _playerSpeed));

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }
 
        _playerVelocity.y += _gravityValue * Time.deltaTime;
        _controller.Move(_playerVelocity * Time.deltaTime);
    }
}
