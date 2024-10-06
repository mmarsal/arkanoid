using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject parentObject;
    public GameObject victoryUI;
    public GameObject restartButton;

    void Update()
    {
        if (parentObject != null)
        {
            int childCount = parentObject.transform.childCount;

            if(childCount == 0)
            {
                victoryUI.SetActive(true);
                // TODO: Fix this button
                // restartButton.SetActive(true);
                Time.timeScale = 0;
            }
        }
        else
        {
            Debug.LogWarning("No parent object assigned.");
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
