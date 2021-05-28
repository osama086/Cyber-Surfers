using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDestroy : MonoBehaviour
{
    public AudioSource healthsound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "obstacle")
        {
            HealthSystem.health--;
            Destroy(hit.collider);
            healthsound.Play();
            return;

        }
    }
}
