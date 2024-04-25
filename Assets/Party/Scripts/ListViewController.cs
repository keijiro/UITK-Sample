using UnityEngine;
using UnityEngine.UIElements;

public class ListViewController : MonoBehaviour
{
    public Party _party;

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var list = root.Q<ListView>("profile-list");
        list.itemsSource = _party.profiles;
    }
}
