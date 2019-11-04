using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{ 

    [SerializeField]
    private Animator _bossAnimator;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player p = collision.GetComponent<Player>();
            if (p != null)
            {
                Destroy(collision.gameObject);
            }
        }
    }




}
