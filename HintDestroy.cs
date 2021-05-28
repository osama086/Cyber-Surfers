using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintDestroy : MonoBehaviour
{
    public static int hint = 3;
	public GameObject quizmenu;
	public GameObject hint1;
	public GameObject hint2;
	public GameObject hint3;
	public GameObject Pass;
	public GameObject Fail;
	// Start is called before the first frame update
	void Start()
    {
        hint1.gameObject.SetActive(true);
        hint2.gameObject.SetActive(true);
        hint3.gameObject.SetActive(true);
        hint = 3;
		quizmenu.gameObject.SetActive(false);
		Time.timeScale = 1f;
		Pass.gameObject.SetActive(false);
		Fail.gameObject.SetActive(false);
	}

    // Update is called once per frame
    void Update()
    {
		if (hint == 3)
		{
			hint1.gameObject.SetActive(true);
			hint2.gameObject.SetActive(true);
			hint3.gameObject.SetActive(true);
		}
		if (hint == 2)
		{
			hint1.gameObject.SetActive(true);
			hint2.gameObject.SetActive(true);
			hint3.gameObject.SetActive(false);
		}
		if (hint == 1)
		{
			hint1.gameObject.SetActive(true);
			hint2.gameObject.SetActive(false);
			hint3.gameObject.SetActive(false);
		}
		if (hint == 0)
		{
			hint1.gameObject.SetActive(false);
			hint2.gameObject.SetActive(false);
			hint3.gameObject.SetActive(false);
			HealthSystem.health = 0;
		}

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
		hint--;
		Fail.gameObject.SetActive(true);
		Invoke("faildelay", 2f);
	}
	public void Bbutton()
	{
		Time.timeScale = 1f;
		quizmenu.gameObject.SetActive(false);
		hint = 3;
		HealthSystem.health++;
		Pass.gameObject.SetActive(true);
		Invoke("passdelay", 2f);
	}
	public void Cbutton()
	{
		Time.timeScale = 1f;
		quizmenu.gameObject.SetActive(false);
	    hint--;
		Fail.gameObject.SetActive(true);
		Invoke("faildelay", 2f);
	}
	void passdelay()
    {
		Pass.gameObject.SetActive(false);
    }
	void faildelay()
    {
		Fail.gameObject.SetActive(false);
    }
}
