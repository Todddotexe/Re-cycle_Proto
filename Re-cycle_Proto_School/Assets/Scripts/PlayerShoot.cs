using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public int bulletCount = 6;
    public float range = 100f;
    public Camera playerView;
    public bool gunPlane = true;
    public Teleport teleport;

    void Start()
    {
        gunPlane = teleport.planeSwap;
    }

    void Update()
    {
        gunPlane = teleport.planeSwap;


        if (Input.GetButtonDown("Fire1"))
        {
            if (bulletCount > 0 && gunPlane == true)
            {
                negShoot();
            }
            if (bulletCount < 6 && gunPlane == false)
            {
                posShoot();
            }
        }
    }

    void negShoot()
    {
        {
            RaycastHit hit;
            if (Physics.Raycast(playerView.transform.position, playerView.transform.forward, out hit, range))
            {
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.Die();
                }
            }
        }
        bulletCount--;
        Debug.Log($"Ammo: {bulletCount}");

    }
    void posShoot()
    {
        {
            RaycastHit hit;
            if (Physics.Raycast(playerView.transform.position, playerView.transform.forward, out hit, range))
            {
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.Die();
                }
            }
        }
        bulletCount++;
        Debug.Log($"Ammo: {bulletCount}");

    }
}
