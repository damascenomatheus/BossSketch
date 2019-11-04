using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOV : MonoBehaviour
{

    [SerializeField]
    private Animator _bossAnimator;
    [SerializeField]
    private GameObject _boss;




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player p = collision.GetComponent<Player>();
            if (p != null)
            {
                if(p.transform.position.x > -0.3)
                {
                    _boss.transform.rotation = new Quaternion(0, 180, 0, 0); 
                } else if(p.transform.position.x < -0.3) {
                    _boss.transform.rotation = new Quaternion(0, 0, 0, 0);
                }
                _bossAnimator.SetBool("isClose", true);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player p = collision.GetComponent<Player>();
            if (p != null)
            {
                if (p.transform.position.x > -0.3)
                {
                    _boss.transform.rotation = new Quaternion(0, 180, 0, 0);
                }
                else if (p.transform.position.x < -0.3)
                {
                    _boss.transform.rotation = new Quaternion(0, 0, 0, 0);
                }
                _bossAnimator.SetBool("isClose", true);
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Player p = collision.GetComponent<Player>();
            if (p != null)
            {
                _boss.transform.rotation = new Quaternion(0, 0, 0, 0);
                _bossAnimator.SetBool("isClose", false);
            }
        }
    }


}
