using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour
{
   #region Singltone
   private static InputManager _instance;

   public static InputManager Instance
   {
      get
      {
         return _instance;
      }
   }
   #endregion

   private Vector3 movementVector = new Vector3();
   
   [SerializeField]
   private Player playerObj;

   [SerializeField]
   private InputField inputField;
   
   private void Awake()
   {
      _instance = this;
   }

   private void Update()
   {
      if (playerObj)
      {
         MoveInput();
      }
   }

   public void SetPlayer(Player pl)
   {
      playerObj = pl;
   }

   public void SpawnPlayer()
   {
     PlayerManager.Instance.SpawnPlayer(); 
   }
   private void MoveInput()
   {
      movementVector.x = Input.GetAxis("Horizontal");
      movementVector.z = Input.GetAxis("Vertical");
      
      playerObj.CmdMovePlayer(movementVector);
      playerObj.MovePlayer(movementVector);
      
   }

   public void SendName(string name)
   {
      PlayerManager.Instance.SetPlayerName(inputField.text);
   }
}
