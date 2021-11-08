using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.UI;

public class Player : NetworkBehaviour
{
   [SyncVar] [SerializeField] 
   private float speed;

   [SyncVar] [SerializeField]
   private string playerNane;

   [SerializeField] private Text nametext;
   
   private Rigidbody rb;

   private void Start()
   {
      rb = this.GetComponent<Rigidbody>();
      if (isServer)
      {
         speed = 3;
         CmdSetPlayerName(PlayerManager.Instance.GetPlayerName);
      }
     

      if (isClient&&isLocalPlayer)
      {
         SetInputManagerPlayer();
      }

      
   }

   public void SetInputManagerPlayer()
   {
      InputManager.Instance.SetPlayer(this);
   }
[Command]
   public void CmdMovePlayer(Vector3 movementVector)
   {
      rb.AddForce(movementVector.normalized * speed);
   }

   [Command]
   public void CmdSetPlayerName(string plName)
   {
      playerNane = plName;
      RpcSetVisibleName(playerNane);
   }

   [ClientRpc]
   public void RpcSetVisibleName(string plName)
   {
      nametext.text = plName;
   }
   public void MovePlayer(Vector3 movementVector)
   {
      rb.AddForce(movementVector.normalized * speed);
   }
}
