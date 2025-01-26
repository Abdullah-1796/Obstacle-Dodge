using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if(!collision.gameObject.CompareTag("Hit") && !collision.gameObject.CompareTag("Ground"))
        {
            collision.gameObject.tag = "Hit";
            hits++;
            Debug.Log("I am hitted " + hits + " time!");
        }
    }
}
