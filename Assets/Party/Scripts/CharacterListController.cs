using UnityEngine;
using UnityEngine.UIElements;

public sealed class CharacterListController : MonoBehaviour
{
    [field:SerializeField]
    public CharacterRegistry Registry { get; set; }

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var list = root.Q<ListView>("character-list");
        list.itemsSource = Registry.profiles;
    }
}
