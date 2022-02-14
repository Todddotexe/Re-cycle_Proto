using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public int bulletCount = 6;
    public float range = 100f;
    public Camera playerView;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(playerView.transform.position, playerView.transform.forward, out hit, range))
        {
            Debug.Log("Haha Gun");
        }
    }
}
