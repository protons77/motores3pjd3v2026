using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Player"))
        {
            
            PlayerInventory player = other.GetComponent<PlayerInventory>();
            
            if (player != null)
            {
                player.AddCoin(); 
                Destroy(gameObject); 
            }
        }
    }
}