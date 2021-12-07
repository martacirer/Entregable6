using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
//proyectil salga disparado hacia arriba,abajo,a la derecha y izquierda
        if(Input.GetKeyDown(KeyCode.UpArrow))
           {
             SpawnProjectile(Quaternion.Euler(0, 0, 0));
           }
        if(Input.GetKeyDown(KeyCode.DownArrow))
           {
             SpawnProjectile(Quaternion.Euler(0, 0, 180));
           }
        if(Input.GetKeyDown(KeyCode.RightArrow))
           {
             SpawnProjectile(Quaternion.Euler(0, 0, -90));
           }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
           {
             SpawnProjectile(Quaternion.Euler(0, 0, 90));
           }
    }

    public void SpawnProjectile(Quaternion rotation)
     {
         Instantiate(projectilePrefab, transform.position,rotation);
     }
}
