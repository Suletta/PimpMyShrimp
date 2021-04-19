using UnityEngine;

public class Bullet : MonoBehaviour
{
    //public Vector2 velocity;
    public float speed;
    [HideInInspector]public float rotation;

    private void Start()
    {
        transform.rotation = Quaternion.Euler(0, rotation, 0);
    }
    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("a");
    }
}