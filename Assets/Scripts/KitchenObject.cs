using UnityEngine;

public class KitchenObject : MonoBehaviour
{
    private IKitchenObjectParent kitchenObjectParent;
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

    public void SetKitchenObjectParent(IKitchenObjectParent kitchenObjectParent)
    {
        if (this.kitchenObjectParent != null)
        {
            this.kitchenObjectParent.ClearKitchenObject();
        }
        this.kitchenObjectParent = kitchenObjectParent;
        if (kitchenObjectParent.HaskitchenObject())
        {
            Debug.LogError("Kitchen object already exists in this parent");
        }
        kitchenObjectParent.SetKitchenObject(this);

        // Move to new position
        transform.parent = kitchenObjectParent.GetKitchenObjectFollowTransform();
        transform.localPosition = Vector3.zero;
    }
    public IKitchenObjectParent GetkitchenObjectParent()
    {
        return kitchenObjectParent;
    }
}
