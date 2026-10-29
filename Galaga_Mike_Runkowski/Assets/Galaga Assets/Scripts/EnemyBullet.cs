using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float speed = 6;


    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);  

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }    

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GalagaPlayer"))
            Destroy(gameObject);
    }
}
