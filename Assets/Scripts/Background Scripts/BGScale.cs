using UnityEngine;
using System.Collections;

public class BGScale : MonoBehaviour {

	void Start () {
		SpriteRenderer sr = GetComponent<SpriteRenderer> ();
		Vector3 temp = transform.localScale;
		
		float width = sr.sprite.bounds.size.x;
		
		float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
		float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;
		
		temp.x = worldScreenWidth / width;
		
		transform.localScale = temp;

	}

}
