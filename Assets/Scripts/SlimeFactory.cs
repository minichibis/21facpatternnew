/** Sam Carpenter
*   Week 6?
*   SlimeFactory.cs
*   basemaker
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SlimeFactory
{
    public abstract Slime makeSlime();
	
	public void initSlime(Slime s){
		s.chooseShape();
		s.chooseStats();
	}
}
