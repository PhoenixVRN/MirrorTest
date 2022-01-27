using System.Collections;
using System.Collections.Generic;
using Mirror;
using Mirror.Examples.Pong;
using UnityEngine;


public class Brick : NetworkBehaviour
{
    public int _scorePoint;
    public int _hp;
    // Start is called before the first frame update
   
    // [ServerCallback]
    // void OnTriggerEnter(Collider other)
    // {
    //     Debug.Log("HP 1"+_hp);
    //     if (other.GetComponent<Ball>() != null)
    //     {
    //         Debug.Log("HP 2"+_hp);
    //         --_hp;
    //         if (_hp <= 0)
    //             NetworkServer.Destroy(gameObject);
    //     }
    // }
    [ServerCallback]
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.transform.GetComponent<Ball>())
        {
            Debug.Log("HP 1 "+_hp);
            --_hp;
                    if (_hp <= 0)
                     NetworkServer.Destroy(gameObject);
        }
    }
}
