using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 _positionDirection;
    public float speed = 5f;
    public float gravity = -3f;
    public float jumpForce = 10f;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        _positionDirection.x = Input.GetAxis("Horizontal")*speed;
        if (Input.GetButtonDown("Jump"))
        {
            _positionDirection.y = jumpForce;
        }

        _positionDirection.y += gravity * Time.deltaTime;
        controller.Move(_positionDirection*Time.deltaTime);
    }
}
