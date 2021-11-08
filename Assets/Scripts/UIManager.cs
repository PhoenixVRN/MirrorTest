using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   private static UIManager _instance;

   public static UIManager Instance
   {
      get
      {
         return _instance;
      }
   }

   private void Awake()
   {
      _instance = this;
   }

   [SerializeField] private GameObject spawnGroupContainer;
   [SerializeField] private GameObject playerStatsGroupContainer;

   [SerializeField] private Text nameField;

   public void SetUIPlayerName(string pl)
   {
      nameField.text = pl;
   }
   public void SpawnGroupToogle()
   {
      spawnGroupContainer.SetActive(!spawnGroupContainer.activeSelf);
   }

   public void PlayerStatsGroupToogle()
   {
      playerStatsGroupContainer.SetActive(!playerStatsGroupContainer.activeSelf);
   }
}
