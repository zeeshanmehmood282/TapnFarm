using Hypertonic.GridPlacement.Enums;
using UnityEngine;
using UnityEngine.UI;

namespace Hypertonic.GridPlacement.Example.PositionOffsetDemo
{
    [RequireComponent(typeof(Button))]
    public class Button_ChangeAlignment : MonoBehaviour
    {
        public static event System.Action<ObjectAlignment> OnChangeAlignmentPressed;

        [SerializeField]
        private ObjectAlignment _objectAlignment;

        private void Start()
        {
            GetComponent<Button>().onClick.AddListener(() => OnChangeAlignmentPressed?.Invoke(_objectAlignment));
        }
    }
}
