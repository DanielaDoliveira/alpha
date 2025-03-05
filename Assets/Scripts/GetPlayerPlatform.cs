using UnityEngine;

public class GetPlayerPlatform : MonoBehaviour
{
    [SerializeField] GameObject player;
    
    private void Start()
    {
        player = GameObject.Find("Player");
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.parent = transform.parent;
        }
    }
}
