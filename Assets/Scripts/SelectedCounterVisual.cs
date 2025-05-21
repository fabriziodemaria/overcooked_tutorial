using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{

    [SerializeField] private ClearCounter counter;
    [SerializeField] private GameObject visualGameObject;
    private void Start()
    {
        Player.Instance.OnSelectedCounterChanged += Player_OnSelectedCounterChanged;
    }

    private void Player_OnSelectedCounterChanged(object sender, Player.OnSelectedCounterChangedEventArgs e)
    {
        Debug.Log("SelectedCounterVisual: Player_OnSelectedCounterChanged: " + e.selectedCounter);
        if (e.selectedCounter == counter)
        {
            ShowVisual();
        }
        else
        {
            HideVisual();
        }
    }

    private void ShowVisual()
    {
        visualGameObject.SetActive(true);
    }
    
    private void HideVisual()
    {
        visualGameObject.SetActive(false);
    }
}
