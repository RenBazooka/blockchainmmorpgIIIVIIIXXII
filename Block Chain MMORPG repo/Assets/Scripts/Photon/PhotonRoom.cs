using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhotonRoom : MonoBehaviourPunCallbacks,IInRoomCallbacks
{
    //Room Info
    public static PhotonRoom room;
    private PhotonView PV;

    
    public int currentScene;
    public int multiplayerScene;

    private void Awake()
    {
        if(PhotonRoom.room == null)
        {
            PhotonRoom.room = this;
        }
        else
        {
            if(PhotonRoom.room != null)
            {
                Destroy(PhotonRoom.room.gameObject);
                PhotonRoom.room = this;


            }
        }
        DontDestroyOnLoad(this.gameObject);
        PV = GetComponent<PhotonView>();
    }
    public override void OnEnable()
    {
        //subscribe to functions

        base.OnEnable();
        PhotonNetwork.AddCallbackTarget(this);
        SceneManager.sceneLoaded += OnSceneFinishedLoading;

        
    }
    public override void OnDisable()
    {
        //subscribe to functions

        base.OnDisable();
        PhotonNetwork.RemoveCallbackTarget(this);
        SceneManager.sceneLoaded -= OnSceneFinishedLoading;


    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
        Debug.Log("Joined a room");
        if (!PhotonNetwork.IsMasterClient)
        {
            return;
        }
        StartGame();
        

    }

    void StartGame()
    {
        Debug.Log("Loading level");
        PhotonNetwork.LoadLevel(multiplayerScene);

    }

    void OnSceneFinishedLoading(Scene scene,LoadSceneMode mode)
    {
        currentScene = scene.buildIndex;
        
        if(currentScene == multiplayerScene)
        {
            CreatePlayer();
        }
        
    }
    
    private void CreatePlayer()
    {
        //creates a network controller but not player characetr
        PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PhotonNetworkPlayer"), transform.position, Quaternion.identity,0);
    }

    

    
    
}
