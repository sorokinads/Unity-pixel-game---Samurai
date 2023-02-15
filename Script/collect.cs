using UnityEngine;
public class collect : MonoBehaviour
{
	[System.Obsolete]
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.name != "food")
		{
			Destroy(gameObject);
			score.scoreAmount += 1;
		}
	}
}
