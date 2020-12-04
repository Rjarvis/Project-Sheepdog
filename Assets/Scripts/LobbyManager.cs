using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject findMatchBtn, searchingPanel;

    // Start is called before the first frame update
    void Start()
    {
        findMatchBtn.SetActive(false);
        searchingPanel.SetActive(false);

        //Connect to the photon Server
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connection to Photon established!");
        Debug.Log(" Connected on <color=blue>" + PhotonNetwork.CloudRegion + "</color> Server at "+ PhotonNetwork.GetPing() +"ms ping!");

        PhotonNetwork.AutomaticallySyncScene = true;
        findMatchBtn.SetActive(true);
    }

    public void FindMatch()
    {
        searchingPanel.SetActive(true);
        findMatchBtn.SetActive(false);
        
    }
}
