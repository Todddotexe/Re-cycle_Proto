using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject playerBody;
    public GameObject posLocation;
    public GameObject negLocation;

    public bool posCanTeleport = true;
    public bool negCanTeleport = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
//            if (posCanTeleport == true)
//            {
                playerBody.transform.position = posLocation.transform.position;
                posCanTeleport = false;
                negCanTeleport = true;
//            }
//            if (negCanTeleport == true)
//            {
//                playerBody.transform.position = negLocation.transform.position;
//                negCanTeleport = false;
//                posCanTeleport = true;
//            }
            
        }
    }
}
