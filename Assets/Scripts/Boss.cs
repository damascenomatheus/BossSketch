using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private float _velocityAnimation = 1.0f;
    private float _canIdle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Idle();
    }

    void Idle()
    {
        if (Time.time > _canIdle)
        {
            transform.position = new Vector3(Random.Range(-1.0f, 1.0f), 2.5f, -10.0f);
            _canIdle = Time.time + _velocityAnimation;
        }
        
    }

    void CloseAttack()
    {
        Debug.Log("Teste");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
            
            
        {
            CloseAttack();
        }
    }


}
