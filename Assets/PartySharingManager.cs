using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartySharingManager : MonoBehaviour
{

    public GameObject sharePartyButton, sharingRoomNameInputField, joinSharingRoomButton;
    // Start is called before the first frame update
    void Start()
    {
        sharePartyButton.GetComponent<Button>().onClick.AddListener(SharePartyButtonPressed);
        joinSharingRoomButton.GetComponent<Button>().onClick.AddListener(JoinSharingRoomButton);
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

    }
}
