/** Sam Carpenter
*   Week 6?
*   SquareSlimeFactory.cs
*   pretty make
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSlimeFactory : SlimeFactory
{
    public override Slime makeSlime(){
		GameObject g = new GameObject();
		g.AddComponent<SquareSlime>();
		return g.GetComponent<SquareSlime>();
	}
}
