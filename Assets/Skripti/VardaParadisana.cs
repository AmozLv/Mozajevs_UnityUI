using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour {
	private string vards;
	private string vecums;
	public GameObject ievadesLauksVards;
	public GameObject ievadesLauksVecums;
	public GameObject tekstaAttelosana;
	private string[] tekstaSakums = {"Zēns vārdā ","Meitene vārdā "};
	private string[] tekstaBeigas = {" vecs"," veca"};

	int indekss;

	public void UzglabatTekstu(){
		
			vards = ievadesLauksVards.GetComponent<InputField> ().text;
			vecums = ievadesLauksVecums.GetComponent<InputField> ().text;
		if (vards.Length > 0 || vecums.Length > 0) {
			char pedejaisBurts = vards.Substring (vards.Length - 1, 1) [0];
			if (pedejaisBurts == 'a' || pedejaisBurts == 'e')
				indekss = 1;
			else
				indekss = 0;
			

			tekstaAttelosana.GetComponent<Text> ().text = tekstaSakums [indekss] + vards.ToUpper () + " ir " + vecums + tekstaBeigas [indekss] + "!";
		}else tekstaAttelosana.GetComponent<Text> ().text = "Nav ievadīts vārds/vecums!";
	}
}

