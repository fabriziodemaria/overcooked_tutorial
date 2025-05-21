using UnityEngine;

public class SelectedCounterVisual : MonoBehaviour
{

    [SerializeField] private BaseCounter counter;
    [SerializeField] private GameObject[] gameObjects;
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
        foreach (GameObject visualGameObject in gameObjects)
        {
            visualGameObject.SetActive(true);
        };
    }
    
    private void HideVisual()
    {
        foreach (GameObject visualGameObject in gameObjects)
        {
            visualGameObject.SetActive(false);
        };
    }
}
