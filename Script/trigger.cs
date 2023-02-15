using UnityEngine;

public class trigger : MonoBehaviour
{
	[System.Obsolete]
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name != "fallTrigger")
			Application.LoadLevel(Application.loadedLevel);

	}
}