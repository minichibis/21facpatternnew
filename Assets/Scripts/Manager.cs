/** Sam Carpenter
*   Week 6?
*   Manager.cs
*   controls
**/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
	SlimeFactory s;
	SlimeFactory t;
    // Start is called before the first frame update
    void Start()
    {
        t = new TriangleSlimeFactory();
		s = new SquareSlimeFactory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)){
			Slime sl = t.makeSlime();
			t.initSlime(sl);
		} else if (Input.GetKeyDown(KeyCode.W)){
			Slime sl = s.makeSlime();
			s.initSlime(sl);
		} else if (Input.GetKeyDown(KeyCode.R)){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }
}
