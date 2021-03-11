/** Sam Carpenter
*   Week 6?
*   TriangleSlime.cs
*   pretty shapoe
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSlime : Slime
{
	Sprite spri;
    public override void chooseShape(){
		spri = Resources.Load<Sprite>("triangle");
		SpriteRenderer s = gameObject.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
		s.sprite = spri;
	}
}
