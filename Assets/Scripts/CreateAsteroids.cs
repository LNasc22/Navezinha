using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAsteroids : MonoBehaviour
{
    public Transform objectToClone;
    Transform spawnPoint;
    public float shootForce = 30;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("LaunchAsteroid", 0.1f, 5.0f);
        spawnPoint = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LaunchAsteroid()
    {
        Transform clone;

        clone = Instantiate(objectToClone, spawnPoint.position, spawnPoint.rotation);
        clone.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce, ForceMode.Impulse);
    }
}
