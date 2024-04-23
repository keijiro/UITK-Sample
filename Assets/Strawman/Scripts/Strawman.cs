using UnityEngine;
using UnityEngine.UIElements;

public sealed class Strawman : MonoBehaviour
{
    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        var anim = GetComponent<Animator>();
        root.Q<Button>("button-dance").clicked += () => anim.Play("Dance");
        root.Q<Button>("button-spin") .clicked += () => anim.Play("Spin");
        root.Q<Button>("button-flip") .clicked += () => anim.Play("Flip");
    }
}
