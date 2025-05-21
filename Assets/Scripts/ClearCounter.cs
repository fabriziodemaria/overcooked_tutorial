using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;

    public void Interact()
    {
        Debug.Log("Interact" + transform.name);
        // Instantiate a tomato at the counter's position
        Transform oTrasform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        oTrasform.localPosition = Vector3.zero;

        kitchenObjectSO.prefab.GetComponent<KitchenObject>().SetKitchenObjectSO(kitchenObjectSO);
        Debug.Log("KitchenObjectSO: " + kitchenObjectSO);
    }
}
