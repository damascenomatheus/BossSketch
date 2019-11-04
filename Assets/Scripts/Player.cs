using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    [SerializeField]
    private Animator _playerAnimator;

    [SerializeField]
    private Rigidbody2D _playerRigibody;

    private Vector2 movement;
   

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    
    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        if (movement.x < 0)
        {
            transform.rotation = new Quaternion(0, 180, 0, 0);

        }
        else if (movement.x > 0)
        {
            transform.rotation = new Quaternion(0, 0, 0, 0);

        }


        _playerRigibody.MovePosition(_playerRigibody.position + movement * _speed * Time.fixedDeltaTime);


        _playerAnimator.SetFloat("Horizontal", movement.x);
        _playerAnimator.SetFloat("Vertical", movement.y); 
        _playerAnimator.SetFloat("Speed", movement.sqrMagnitude); 
    }

}
