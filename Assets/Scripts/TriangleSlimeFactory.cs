/** Sam Carpenter
*   Week 6?
*   TriangleSlimeFactory.cs
*   pretty make
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleSlimeFactory : SlimeFactory
{
    public override Slime makeSlime(){
		GameObject g = new GameObject();
		g.AddComponent<TriangleSlime>();
		return g.GetComponent<TriangleSlime>();
	}
}
