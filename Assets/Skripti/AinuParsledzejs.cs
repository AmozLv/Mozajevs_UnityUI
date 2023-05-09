using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
	public void UzSakumu(){
		SceneManager.LoadScene ("Sakums", LoadSceneMode.Single);
	}
	public void UzMain(){
		SceneManager.LoadScene ("Aina1", LoadSceneMode.Single);
	}
	public void apturet(){
		Application.Quit ();
		}
	}

