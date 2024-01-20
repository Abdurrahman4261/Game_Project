using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class online : MonoBehaviourPunCallbacks
{
    
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();    
    }
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
        Debug.Log("sunucu");
        PhotonNetwork.JoinLobby();
        
    }
    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
        Debug.Log("lobby");
        //PhotonNetwork.JoinOrCreateRoom("oda",new RoomOptions{MaxPlayers=4 , IsOpen=true,IsVisible=true},TypedLobby.Default);
    }
    // public override void OnJoinedRoom()
    // {
    //     base.OnJoinedRoom();
    //     Debug.Log("oda");
    //     GameObject nesne =PhotonNetwork.Instantiate("multi_2",new Vector3(11,8,0),Quaternion.identity,0,null);

    // }
}
