using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class AnimalPopupWindow : MonoBehaviour
    {
        /// <summary>
        /// Т.к. я не знаю, как часто используется это окно, при закрытии оно будет именно уничтожаться.
        /// </summary>
        public void CloseWindow()
        {
            Destroy(this.gameObject);
        }
    }
}