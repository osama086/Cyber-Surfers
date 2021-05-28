using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public static int health = 3;
	public GameManager gameManager;
	public GameObject health1;
	public GameObject health2;
	public GameObject health3;
	
	// Start is called before the first frame update
	void Start()
    {
		health1.gameObject.SetActive(true);
		health2.gameObject.SetActive(true);
		health3.gameObject.SetActive(true);
		health = 3;
		
	}

	// Update is called once per frame
	void Update()
	{
		if (health == 3)
		{
			health1.gameObject.SetActive(true);
			health2.gameObject.SetActive(true);
			health3.gameObject.SetActive(true);
		}
		if (health == 2)
		{
			health1.gameObject.SetActive(true);
			health2.gameObject.SetActive(true);
			health3.gameObject.SetActive(false);
		}
	   if (health == 1)
		{
			health1.gameObject.SetActive(true);
			health2.gameObject.SetActive(false);
			health3.gameObject.SetActive(false);
		}
		if (health == 0)
		{
			health1.gameObject.SetActive(false);
			health2.gameObject.SetActive(false);
			health3.gameObject.SetActive(false);
			gameManager.GameOver();
		}
	}
	
}
