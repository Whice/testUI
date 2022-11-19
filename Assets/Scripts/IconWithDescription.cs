using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
namespace UI
{
    public class IconWithDescription : MonoBehaviour
    {
        [Header("Resources")]
        [SerializeField] private Sprite icon = null;
        [SerializeField] private String descriptionText = null;
        [SerializeField] private Color descriptionColor = Color.white;

        [Header("Self component reference")]
        [SerializeField] private Image iconImage = null;
        [SerializeField] private TextMeshProUGUI textMeshPro = null;
        [SerializeField] private ResizableIfOverflow resizableScript = null;

        /// <summary>
        /// Выставить все настройки указанные компонентами в инспекторе.
        /// </summary>
        [EditorButton("Set settings for components")]
        public void SetSettingsForComponents()
        {
            this.iconImage.sprite = this.icon;
            this.textMeshPro.text = this.descriptionText;
            this.textMeshPro.color = this.descriptionColor;
            this.resizableScript.ResizeContainer();
        }
    }
}