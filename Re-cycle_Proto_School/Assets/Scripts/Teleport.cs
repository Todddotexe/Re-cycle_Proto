using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject playerBody;
    public CharacterController characterController;

    public Transform posPosition;
    public Transform negPosition;

    public bool planeSwap = true;

    void Update()
    {
        if (planeSwap == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                characterController.enabled = false;
                playerBody.transform.position = posPosition.transform.position;
                planeSwap = false;
                characterController.enabled = true;
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                characterController.enabled = false;
                playerBody.transform.position = negPosition.transform.position;
                planeSwap = true;
                characterController.enabled = true;
            }
        }
    }

}
