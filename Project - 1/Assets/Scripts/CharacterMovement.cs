using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{
    private CharacterController _controller;
    private Vector3 _positionDirection;
    public float speed = 5f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    private int _jumpCount = 0;
    public int jumpCountMax = 2;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        if (_controller.isGrounded)
        {
            _positionDirection.y = 0;
            _jumpCount = 0;
        }
        
        _positionDirection.x = Input.GetAxis("Horizontal")*speed;
        
        if (Input.GetButtonDown("Jump") && _jumpCount < jumpCountMax)
        {
            _positionDirection.y = jumpForce;
            _jumpCount++;
        }

        _positionDirection.y += gravity * Time.deltaTime;
        _controller.Move(_positionDirection*Time.deltaTime);
    }
}
