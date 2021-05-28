using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "obstacle")
        {
            gameOverPanel.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void restat()
    {

        SceneManager.LoadScene(1);
    }
}
