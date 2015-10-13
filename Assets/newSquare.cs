using UnityEngine;
using System.Collections;

public class newSquare : MonoBehaviour {

	public Vector3 startPosition;

	public Object redSquare, blueSquare, greenSquare, yellowSquare;

	private float number;


	void Start () {
	
		startPosition = new Vector3 (0.0f, 1.0f, -7.0f);

	}
	

	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		number = Random.Range (0, 4);
		print (number);
		if (gameObject.tag.Equals (other.tag) && !other.gameObject.layer.Equals(gameObject.layer)) {
			//score++
			if(number==0){
				Instantiate(redSquare, startPosition,  Quaternion.identity);
			}else if(number==1){
				Instantiate(blueSquare, startPosition,  Quaternion.identity);
			}else if(number==2){
				Instantiate(greenSquare, startPosition,  Quaternion.identity);
			}else{
				Instantiate(yellowSquare, startPosition,  Quaternion.identity);
			}
			Destroy (this.gameObject);

		} else if( !other.gameObject.layer.Equals(gameObject.layer) ) {
			//score--
			if(number==0){
				Instantiate(redSquare, startPosition,  Quaternion.identity);
			}else if(number==1){
				Instantiate(blueSquare, startPosition,  Quaternion.identity);
			}else if(number==2){
				Instantiate(greenSquare, startPosition,  Quaternion.identity);
			}else{
				Instantiate(yellowSquare, startPosition,  Quaternion.identity);
			}
			Destroy (this.gameObject);
		}
	}

	
}
