using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            AudioAsteroid.FindObjectOfType<AudioAsteroid>().explosion.Play();
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            Movement.FindObjectOfType<Movement>().score += 5;
        }
    }
}
