using UnityEngine;

public class ChangeColorOnCollision : MonoBehaviour
{
    private Renderer objRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objRenderer = GetComponent<Renderer>();
    }

    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Ball"))
       {
           objRenderer.material.color = new Color(Random.value, Random.value, Random.value);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
