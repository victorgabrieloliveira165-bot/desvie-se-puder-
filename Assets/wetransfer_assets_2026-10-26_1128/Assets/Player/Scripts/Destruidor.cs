using UnityEngine;

public class Destruidor : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

}