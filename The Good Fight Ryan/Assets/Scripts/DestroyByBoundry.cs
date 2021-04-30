using UnityEngine;

public class DestroyByBoundry : MonoBehaviour
{

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "EnemyRocket")
        {
            Destroy(other.gameObject);
        }
    }

}
