using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;



public class ObjektuParvietosana : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	
		private RectTransform transformKomponente;
		public Canvas kanva;

		void Start(){
		transformKomponente=GetComponent<RectTransform>();
		}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Izdarīts peles klikšķis uz objekta!");
	
	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsākta objekta vilkšana!");
	}
	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek objekta pārvietošana!");
		transformKomponente.anchoredPosition += notikums.delta / kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Pārtraukta objekta vilkšana!");
	}
	}

