using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public Vector3 velocity;
    public GameObject newBall;
    public AudioSource beep;
    public TMP_Text text;
    public TMP_Text lives;
    public GameObject gameOverUI;
    public GameObject restartButton;

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            bool isSide = other.gameObject.name == "Left" || other.gameObject.name == "Right";

            if(isSide)
            {
                velocity = new Vector3(-velocity.x, velocity.y, velocity.z);
            }
            else
            {
                velocity = new Vector3(velocity.x, velocity.y, -velocity.z);
            }
        }
        else if(other.CompareTag("Paddle"))
        {
            velocity = new Vector3(velocity.x, velocity.y, -velocity.z);
        }
        else if(other.CompareTag("BottomWall"))
        {
            int currentLives = int.Parse(lives.text);
            currentLives--;
            lives.text = currentLives.ToString();

            if(currentLives == 0)
            {
                Destroy(gameObject);
                gameOverUI.SetActive(true);
                restartButton.SetActive(true);
                Time.timeScale = 0;
            } else {
                transform.position = Vector3.zero;
            }
        }
        else if(other.CompareTag("Block"))
        {
            velocity = new Vector3(velocity.x, velocity.y, -velocity.z);
        }

        beep.Play();
    }
}
