using UnityEngine;

public class TinyShip : MonoBehaviour
{

    public float speed = 1;
    public GameObject explosion;


    void Update()
    {

        transform.Translate(-transform.up * speed * Time.deltaTime);
    
        if ((speed > 1) || (speed < 10))
        {
            speed += 0.015f;
        }
        
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet") || collision.gameObject.CompareTag("GalagaPlayer"))
        {
            if (collision.gameObject.CompareTag("PlayerBullet"))
                Destroy(collision.gameObject);

            GameObject temp = Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
    }

}