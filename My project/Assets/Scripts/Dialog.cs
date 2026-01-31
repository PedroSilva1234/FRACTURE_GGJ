using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    public Sprite profile;
    [TextArea]
    public string speechTxt;
    public string actorName;

    private DialogueController dc;

    private void Start()
    {
        dc = FindFirstObjectByType<DialogueController>();
    }

    public void Interact()
    {
        if (dc != null)
        {
            dc.Speech(profile, speechTxt, actorName);
        }
        else
        {
            Debug.LogWarning("DialogueController não encontrado na cena!");
        }
    }
}
