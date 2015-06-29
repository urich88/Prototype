using UnityEngine;
using System.Collections;

/* SINGLE TONE THAN CREATES INSTANCE OF THE GM*/

public class GameManagerSingleTone : MonoBehaviour {
	
	private static GameManager _instance;
	
	public GameManager instance {
		
		get {
			
			return _instance;}
		set {
			if (_instance == null) {
				
				_instance = value;
			} else { 
				
				Destroy (value.gameObject);
			}
		}
	}
	
	
}
