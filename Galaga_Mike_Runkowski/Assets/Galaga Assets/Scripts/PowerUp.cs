using UnityEngine;

public class PowerUp : MonoBehaviour
{

    public float speed = 2f;
    public float giftTimer = 0, giftWait = 10;
    public GameObject explosion;


    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);      
        giftTimer += Time.deltaTime;

        if (giftTimer > giftWait)
        {
            giftTimer = 0;
        }

        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }        

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GalagaPlayer"))
        {

            giftWait += 5;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            GameObject temp = Instantiate(explosion,transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
    }

}        