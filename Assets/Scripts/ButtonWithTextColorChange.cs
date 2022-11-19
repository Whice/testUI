using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI
{
    public class ButtonWithTextColorChange : Button
    {
        private List<TextMeshProUGUI> childrenTexts = new List<TextMeshProUGUI>();
        protected override void Awake()
        {
            base.Awake();

            int childrenCount = this.transform.childCount;
            for (int i = 0; i < childrenCount; i++)
            {
                Transform child = this.transform.GetChild(i);
                TextMeshProUGUI tmpComponent = child.GetComponent<TextMeshProUGUI>();
                if (tmpComponent != null)
                {
                    this.childrenTexts.Add(tmpComponent);
                }
            }
        }
        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            var colors = this.colors;
            foreach (TextMeshProUGUI text in this.childrenTexts)
            {
                text.color = Color.white;
            }
        }
        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            float mult = 1 / 255f;
            Color newColor = new Color(224*mult, 202 * mult, 146 * mult, 1);
            foreach (TextMeshProUGUI text in this.childrenTexts)
            {
                text.color = newColor;
            }
        }
    }
}