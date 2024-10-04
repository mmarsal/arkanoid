using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    private Vector3 velocity = new Vector3(0, 0, -2);
    public GameObject paddle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BottomWall"))
        {
            Destroy(gameObject);
        } else if(other.CompareTag("Paddle")) {
            Destroy(gameObject);
            paddle.transform.localScale = new Vector3(3f, 1f, 0.5f);
        }
    }
}
