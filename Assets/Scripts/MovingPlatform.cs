using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 5f;
    public float range = 10f;
    private Vector3 startPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Mathf.PingPong(Time.time * speed, range);
        transform.position = startPosition + new Vector3(movement, 0, 0);   
    }
}
