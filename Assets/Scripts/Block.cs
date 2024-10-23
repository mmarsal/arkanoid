using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Block : MonoBehaviour
{
    private Color randomColor;

    private Renderer blockRenderer;

    private int hitCount;

    public TMP_Text text;

    private bool spawnsPowerup;

    public GameObject powerupParent;

    private Transform selectedPowerup;

    // Start is called before the first frame update
    void Start()
    {
        blockRenderer = GetComponent<Renderer>();

        randomColor = new Color(Random.value, Random.value, Random.value);

        blockRenderer.material.color = randomColor;

        hitCount = Random.Range(1, 6);

        int randomNumber = Random.Range(0, 100);
        if (randomNumber < 20)
        {
            int childCount = powerupParent.transform.childCount;
            int randomIndex = Random.Range(0, childCount);

            selectedPowerup = powerupParent.transform.GetChild(randomIndex);
            spawnsPowerup = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        hitCount--;

        if (hitCount == 0)
        {
            Destroy(gameObject);
            int currentScore = int.Parse(text.text);
            currentScore += 10;
            text.text = currentScore.ToString();

            if(spawnsPowerup)
            {
                Quaternion rotation = Quaternion.Euler(0, 0, 90);
                Instantiate(selectedPowerup, transform.position, rotation);
            }
        }
    }
}
