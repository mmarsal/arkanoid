using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupExtraBall : MonoBehaviour
{
    private Vector3 velocity = new Vector3(0, 0, -2);
    public GameObject newBall;

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
            Vector3 position = Vector3.zero;
            Instantiate(newBall, position, Quaternion.identity);
        }
    }
}
