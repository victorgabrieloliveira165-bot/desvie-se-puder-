using UnityEngine;

public class Moeda : MonoBehaviour
{

    public AudioSource somDaMoeda;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {   
            GetComponent<SpriteRenderer>().enabled = false;
            other.GetComponent<Player>().AumentarQuantidadeDeMoedas();
            somDaMoeda.Play();
            Destroy(gameObject, 0.6f);
        }
    }
}
