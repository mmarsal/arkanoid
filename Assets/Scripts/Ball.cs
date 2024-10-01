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

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Wall"))
        {
            Debug.Log(other.gameObject.name + " hit");
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
            Vector3 position = Vector3.zero;
            Instantiate(newBall, position, Quaternion.identity);
            Destroy(gameObject);
        }
        Debug.Log(other.gameObject.name);
        text.text = Random.Range(1, 10).ToString();
        beep.Play();
    }
}
