using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySharingManager : MonoBehaviour
{

    public GameObject sharePartyButton, sharingRoomNameInputField, joinSharingRoomButton;

    NetworkedClient networkedClient;
    // Start is called before the first frame update
    void Start()
    {
        sharePartyButton.GetComponent<Button>().onClick.AddListener(SharePartyButtonPressed);
        joinSharingRoomButton.GetComponent<Button>().onClick.AddListener(JoinSharingRoomButton);

        networkedClient = GetComponent<NetworkedClient>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SharePartyButtonPressed()
    {

    }

    public void JoinSharingRoomButton()
    {
        if (sharingRoomNameInputField.GetComponent<InputField>())
        {
            string name = sharingRoomNameInputField.GetComponent<InputField>().text;
            networkedClient.SendMessageToHost(ClientToServerSignifiers.JoinSharingRoom + "," + name);
        }
        else
            Debug.Log("Issue with input field");
    }
}

static public class ClientToServerSignifiers
{
    public const int JoinSharingRoom = 1;
}

static public class ServerToClientSignifiers
{

}
