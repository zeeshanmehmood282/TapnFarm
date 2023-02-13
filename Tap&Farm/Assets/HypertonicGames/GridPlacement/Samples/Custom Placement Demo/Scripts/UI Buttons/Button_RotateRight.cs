using UnityEngine;
using UnityEngine.UI;

namespace Hypertonic.GridPlacement.Example.CustomPlacement
{
    [RequireComponent(typeof(Button))]
    public class Button_RotateRight : MonoBehaviour
    {
        public static event System.Action OnRotateRightPressed;

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(() => OnRotateRightPressed?.Invoke());
        }
    }
}