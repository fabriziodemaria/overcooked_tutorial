using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    private ClearCounter clearCounter;
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    public KitchenObjectSO GetKitchenObjectSO()
    {
        return kitchenObjectSO;
    }

    public void SetKitchenObjectSO(KitchenObjectSO kitchenObjectSO)
    {
        this.kitchenObjectSO = kitchenObjectSO;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    public void SetClearCounter(ClearCounter clearCounter)
    {
        // Update the kitchen object in each counters
        if (this.clearCounter != null)
        {
            this.clearCounter.ClearKitchenObject();
        }
        this.clearCounter = clearCounter;
        if (clearCounter.HaskitchenObject())
        {
            Debug.LogError("Kitchen object already exists in this counter");
        }
        clearCounter.SetKitchenObject(this);

        // Move to new position
        transform.parent = clearCounter.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }
    public ClearCounter GetClearCounter()
    {
        return clearCounter;
    }
}
