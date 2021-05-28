using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizSystem : MonoBehaviour
{
    public GameObject quizmenu;
    // Start is called before the first frame update
    void Start()
    {
        quizmenu.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "Computer")
        {
            quizmenu.gameObject.SetActive(true);
            Destroy(hit.collider);
            Time.timeScale = 0f;
        }
    }
    public void Abutton()
    {
        Time.timeScale = 1f;
        quizmenu.gameObject.SetActive(false);
        HintDestroy.hint--;
    }
    public void Bbutton()
    {
        Time.timeScale = 1f;
        quizmenu.gameObject.SetActive(false);
        HealthSystem.health++;
    }
    public void Cbutton()
    {
        Time.timeScale = 1f;
        quizmenu.gameObject.SetActive(false);
        HintDestroy.hint--;
    }
}
