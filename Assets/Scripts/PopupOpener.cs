using UnityEngine;

namespace UI
{
    public class PopupOpener : MonoBehaviour
    {
        [SerializeField] private AnimalPopupWindow window = null;
        [SerializeField] private Transform parent = null;

        public void OpenPopup()
        {
            Instantiate(this.window, this.parent);
        }
    }
}