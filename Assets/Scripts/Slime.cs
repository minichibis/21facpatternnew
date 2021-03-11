/** Sam Carpenter
*   Week 6?
*   Slime.cs
*   base
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Slime : MonoBehaviour
{
	float size = 1f;
	float timer = 0.0f;
	
    public abstract void chooseShape();
	public void chooseStats(){
		transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), -1);
		size = Random.Range(0.5f, 2f);
		transform.localScale = new Vector3(size, size, 1f);
	}
	
	void Update(){
		timer += Time.deltaTime;
		float s = size * Mathf.Sin(timer * 4) * 0.15f;
		transform.localScale = new Vector3(size + s, size - s, 1f);
	}
}
