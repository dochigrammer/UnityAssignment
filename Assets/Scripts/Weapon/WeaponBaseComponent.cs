using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBaseComponent : MonoBehaviour
{
    public GameObject Bullet;
    public GameObject Muzzle;

    public bool IsExpiredCoolTime()
    {
        return true;
    }

    public void Attack()
    {
        GameObject bullet = Instantiate(Bullet);

        if( bullet != null)
        {
            Vector3 initial_location = gameObject.transform.position;

            if(Muzzle != null)
            {
                initial_location = Muzzle.transform.position;
            }

            bullet.transform.position = initial_location;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
