using System;
using UnityEngine;

public class ContainerCounter : BaseCounter
{
    public event EventHandler OnPlayerGrabbedObject;
    public override void Interact(Player player)
    {
        Transform oTrasform = Instantiate(kitchenObjectSO.prefab, counterTopPoint);
        oTrasform.GetComponent<KitchenObject>().SetKitchenObjectParent(player);
        OnPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
    }
}
