using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] GameObject trap;

    private void Update()
    {
        TrapRotate();
    }

    private void TrapRotate()
    {
        transform.Rotate(0, 0, 360 * rotationSpeed * Time.deltaTime);
    }
}
