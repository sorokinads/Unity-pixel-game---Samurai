using UnityEngine;

public class cameramove : MonoBehaviour
{
    public GameObject player;
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x+6, 2.61f, -10f);
        Vector3 destination = transform.position;
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
   
}
}
