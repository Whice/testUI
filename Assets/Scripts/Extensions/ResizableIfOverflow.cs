using TMPro;
using UnityEngine;

public class ResizableIfOverflow : MonoBehaviour
{
    private TextMeshProUGUI text = null;
    // Start is called before the first frame update
    void Start()
    {
        ResizeContainer();
    }

    /// <summary>
    /// Подогнать размер контейнера под длину строки.
    /// </summary>
    [EditorButton("Resize container")]
    public void ResizeContainer()
    {
        this.text = GetComponent<TextMeshProUGUI>();
        this.text.autoSizeTextContainer = true;
    }
}
