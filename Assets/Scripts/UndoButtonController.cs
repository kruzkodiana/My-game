using UnityEngine;
using UnityEngine.UI;

public class UndoButtonController : MonoBehaviour
{
    [Header("Кнопки")]
    public Button undoButton;
    public Button redoButton;

    private bool canUndo = true;
    private bool canRedo = true;

    void Update()
    {
        if (undoButton != null) undoButton.interactable = canUndo;
        if (redoButton != null) redoButton.interactable = canRedo;
    }

    public void OnUndoClick()
    {
        if (!canUndo) return;
        Debug.Log("Кнопка Undo нажата!");
        canRedo = true;
    }

    public void OnRedoClick()
    {
        if (!canRedo) return;
        Debug.Log("Кнопка Redo нажата!");
    }
}