using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    [SerializeField]
    private Animator _playerAnimator;

    private Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * movement.x * _speed);
        transform.Translate(Vector3.up * Time.deltaTime * movement.y * _speed);

        _playerAnimator.SetFloat("Horizontal", movement.x);
        _playerAnimator.SetFloat("Vertical", movement.y);
        _playerAnimator.SetFloat("Speed", movement.sqrMagnitude); 
    }

}
