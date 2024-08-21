using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    public float speedForce = 2;
    public int life = 5;
    public int score;
    public Text textVida;
    public Text textGameOver;
    public Text textScore;
    private AudioSource hit;
    private AudioSource gameOver;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        hit = GetComponent<AudioSource>();
        gameOver = textGameOver.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentação da nave
        if (Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetKey(KeyCode.W)))
        {
            rb.AddForce(transform.right * speedForce);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || (Input.GetKey(KeyCode.S)))
        {
            rb.AddForce(transform.right * (-speedForce));
        }

        //=======================================================================================================

        // Rotação da nave
        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.Rotate(0, 1.8f, 0);
        }

        else if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            transform.Rotate(0, -1.8f, 0);
        }

        //=======================================================================================================

        // Textos mostrando a vida e pontos
        textVida.text = "Vida: " + life.ToString();
        textScore.text = "Pontos: " + score.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {
            Destroy(collision.gameObject);
            life-=1;
            hit.Play();
        }

        if (life < 0)
        {
            life = 0;
        }

        if (life == 0)
        {
            gameOver.Play();
            textGameOver.text = "Game Over";
            Time.timeScale = 0;
        }
    }
}
