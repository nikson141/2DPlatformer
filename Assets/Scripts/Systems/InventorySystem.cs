using TreeEditor;
using UnityEngine;
using UnityEngine.UI;

public class InventorySystem : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;

    [SerializeField] private GameObject bag;
    [SerializeField] private GameObject inventoryUI;

    private void Start()
    {
        inventoryUI.SetActive(false);
        bag.SetActive(true);
    }
    

    public void OpenInventoryUI()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }
}


