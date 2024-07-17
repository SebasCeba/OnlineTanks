using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody; //This was optional 
    [SerializeField] private float shootingStrength; 
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform shootingPoint; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); 
        }
    }
    void Shoot()
    {
        GameObject temporaryBullet = Instantiate(bulletPrefab, shootingPoint.position, shootingPoint.rotation);

        temporaryBullet.GetComponent<Rigidbody>().AddForce(myRigidbody.velocity + temporaryBullet.transform.forward * shootingStrength, ForceMode.VelocityChange); 

        Destroy(temporaryBullet, 2f); 
    }
}
