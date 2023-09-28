using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScript : MonoBehaviour
{
    public Transform projectilePosition;
    public GameObject projectile;

    private void Update()
    {
        Instantiate(projectile, projectilePosition.position, projectilePosition.rotation);
    }

}
