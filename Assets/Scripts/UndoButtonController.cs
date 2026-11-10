using UnityEngine;

public class UndoButtonController : MonoBehaviour
{
    public void OnUndoClick()
    {
        Debug.Log("Кнопка Undo нажата!");
    }

    public void OnRedoClick()
    {
        Debug.Log("Кнопка Redo нажата!");
    }
}