using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CanSistemi : MonoBehaviour
{
	private float Can = 100;
	public GameObject karakterkamerasi;
	public Slider CanSlider;

	private void Update()
    {
    }

	public void GetDmage(float miktar)
	{

		Can -= miktar;
		CanSlider.value = Can;

		if (Can <= 0)
		{
			karakterkamerasi.SetActive (false);
			SceneManager.LoadScene("kaybetme");
		}
	}

}
