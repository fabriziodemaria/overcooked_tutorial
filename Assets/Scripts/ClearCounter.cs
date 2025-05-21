using UnityEngine;

public class ClearCounter : MonoBehaviour
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private Transform counterTopPoint;
    [SerializeField] private ClearCounter secondaryCounter;

    private KitchenObject kitchenObject;
    [SerializeField] private bool testing;


    private void Update()
    {
        if (testing)
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (kitchenObject != null)
                {
                    kitchenObject.SetClearCounter(secondaryCounter);
                }
            }
        }
    }
    public void Interact()
    {
        if (kitchenObject == null)
        {
            Transform oTrasform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
            oTrasform.GetComponent<KitchenObject>().SetClearCounter(this);
        }
        else
        {
            Debug.Log(kitchenObject.GetClearCounter());
        }
    }

    public Transform GetKitchenObjectFollowTransform()
    {
        return counterTopPoint;
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;
    }
    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HaskitchenObject()
    {
        return kitchenObject != null;
    }
}
 