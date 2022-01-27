using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using Mirror.Examples.Pong;
using UnityEngine;
using UnityEngine.UI;

public class LeftLost : NetworkBehaviour
{
    [SerializeField] private GameObject leftLose;
    [ServerCallback]
    void OnCollisionEnter2D(Collision2D col) 
    {
        if (col.transform.GetComponent<Ball>())
        {
            Debug.Log("Left Lose ");
            leftLose.SetActive(true);
        }
    }
}
