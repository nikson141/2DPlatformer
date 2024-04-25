using UnityEngine;

public class SpawnSystem : MonoBehaviour
{
    [SerializeField] private GameObject item;
    [SerializeField] private Transform spawnPos;

    public void SpawnDroppedItem()
    {
        Instantiate(item, spawnPos.position, Quaternion.identity);
    }
}
