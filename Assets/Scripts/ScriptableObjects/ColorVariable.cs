using UnityEngine;

[CreateAssetMenu]
public class ColorVariable : ScriptableObject
{
    [SerializeField]
    private Color value;
    public Color Value
    {
        get => value;
        set
        {
            this.value = value;
        }
    }
}