using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectile;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            for(int i = 0; i < projectile.Length; i++)
            {
                projectile[i].SetActive(true);
            }
            Destroy(gameObject);
        }
    }
}
