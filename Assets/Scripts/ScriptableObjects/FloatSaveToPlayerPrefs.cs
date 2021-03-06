using OpenSkiJumping.ScriptableObjects.Variables;
using UnityEngine;

namespace OpenSkiJumping.ScriptableObjects
{
    public class FloatSaveToPlayerPrefs : MonoBehaviour
    {
        public string variableName;
        public FloatVariable value;

        private void OnEnable()
        {
            value.Value = PlayerPrefs.GetFloat(variableName);
        }

        private void OnDisable()
        {
            PlayerPrefs.SetFloat(variableName, value.Value);
        }
    }
}