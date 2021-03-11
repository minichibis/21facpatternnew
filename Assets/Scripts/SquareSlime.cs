/** Sam Carpenter
*   Week 6?
*   SquareSlime.cs
*   pretty shapoe
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSlime : Slime
{
	Sprite spri;
    public override void chooseShape(){
		spri = Resources.Load<Sprite>("square");
		SpriteRenderer s = gameObject.AddComponent(typeof(SpriteRenderer)) as SpriteRenderer;
		s.sprite = spri;
	}
}
