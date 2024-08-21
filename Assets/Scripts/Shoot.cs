using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform objectToClone;
    Transform spawnPoint;
    public float shootForce = 40;
    private AudioSource laserShoot;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = transform.GetChild(0);
        laserShoot = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        // Faz a nave atirar os tiros pelos canhões
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform clone;

            clone = Instantiate(objectToClone, spawnPoint.position, spawnPoint.rotation);
            clone.GetComponent<Rigidbody>().AddForce(spawnPoint.up * shootForce, ForceMode.Impulse);
            laserShoot.Play();
        }

    }
}
