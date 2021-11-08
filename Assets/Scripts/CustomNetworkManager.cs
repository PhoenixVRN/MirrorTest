using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CustomNetworkManager : NetworkManager
{
    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Connect to Server");
        UIManager.Instance.SpawnGroupToogle();
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        UIManager.Instance.PlayerStatsGroupToogle();
        base.OnClientDisconnect(conn);
    }

    public override void OnServerDisconnect(NetworkConnection conn)
    {
        UIManager.Instance.PlayerStatsGroupToogle();
        base.OnServerDisconnect(conn);
    }
}
