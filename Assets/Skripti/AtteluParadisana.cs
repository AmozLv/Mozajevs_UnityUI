using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject mainigaisAttels;
	public Sprite[] atteluMasivs;
	public GameObject garSlaideris;
	public GameObject platSlaideris;
	public GameObject AvizeImg;
	public GameObject PavarImg;
	public GameObject BantImg;
	public GameObject VioletKreklImg;
	public GameObject SirdsKreklImg;
	public GameObject ZalsKreklImg;
	public GameObject ToggleCepures;

	public void cepuruAttelosana(bool vertiba){
		AvizeImg.SetActive (vertiba);
		PavarImg.SetActive (vertiba);
		BantImg.SetActive (vertiba);

	}
	public void apgerbuAttelosana(bool vertiba){
		VioletKreklImg.SetActive (vertiba);
		SirdsKreklImg.SetActive (vertiba);
		ZalsKreklImg.SetActive (vertiba);

	}
	public void izkritosais(int sk){
		if (sk == 0)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [0];
		else if (sk == 1)
			mainigaisAttels.GetComponent<Image> ().sprite = atteluMasivs [1];
		else
			Debug.Log ("Nav piesaistīts attēls");
	}

	public void MainitPlatumu()
	{
		float garumaVertiba = garSlaideris.GetComponent<Slider>().value;
		float platumaVertiba = platSlaideris.GetComponent<Slider>().value;
		Vector2 lielums = mainigaisAttels.transform.localScale;
		lielums.x = Mathf.Clamp(platumaVertiba, 0f, 2f); // ierobežot lielumu no 0 līdz 2
		mainigaisAttels.transform.localScale = lielums;
		ZalsKreklImg.transform.localScale = lielums;
		SirdsKreklImg.transform.localScale = lielums;
		VioletKreklImg.transform.localScale = lielums;
		BantImg.transform.localScale = lielums;
		PavarImg.transform.localScale = lielums;
		AvizeImg.transform.localScale = lielums;

	}

	public void MainitGarumu()
	{
		float garumaVertiba = garSlaideris.GetComponent<Slider>().value;
		float platumaVertiba = platSlaideris.GetComponent<Slider>().value;
		Vector2 lielums = mainigaisAttels.transform.localScale;
		lielums.y = Mathf.Clamp(garumaVertiba, 0f, 2f); // ierobežot lielumu no 0 līdz 2
		mainigaisAttels.transform.localScale = lielums;
		ZalsKreklImg.transform.localScale = lielums;
		SirdsKreklImg.transform.localScale = lielums;
		VioletKreklImg.transform.localScale = lielums;
		BantImg.transform.localScale = lielums;
		PavarImg.transform.localScale = lielums;
		AvizeImg.transform.localScale = lielums;
	}
}