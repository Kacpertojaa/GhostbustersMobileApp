using UnityEngine;

public class checkEnemy : MonoBehaviour
{
    public GameObject enemy; // Obiekt przeciwnika
    public GameObject exitDoorPrefab; // Prefab drzwi wyjściowych

    void Update()
    {
        if (enemy == null)
        {
            Instantiate(exitDoorPrefab, transform.position, Quaternion.identity);
            this.enabled = false;
        }
    }
}