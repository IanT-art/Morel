using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScriptFinal : MonoBehaviour
{
    public Transform projectilePosition;
    public GameObject projectile;

    // Update is called once per frame
    void Update()
    {
        Instantiate(projectile, projectilePosition.position, projectilePosition.rotation);
    }
}
