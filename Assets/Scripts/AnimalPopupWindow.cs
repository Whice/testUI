using UnityEngine;

namespace UnityEditorInternal
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