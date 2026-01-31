using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DialogueButton : MonoBehaviour
{
    public string actorName;
    [TextArea(3, 10)] public string speechText;
    public Sprite profile;

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(ShowDialogue);
    }

    public void ShowDialogue()
    {
        // Verifica se a instância existe
        if (DialogueController.instance == null) return;

        GameObject janela = DialogueController.instance.dialogueObj;

        // VERIFICAÇÃO DE SEGURANÇA: Checa se o objeto 'janela' não foi destruído
        if (janela == null)
        {
            Debug.LogWarning("A janela de diálogo foi destruída ou não foi atribuída!");
            return;
        }

        if (janela.activeSelf)
        {
            DialogueController.instance.CloseDialogue();
        }
        else
        {
            DialogueController.instance.Speech(profile, speechText, actorName);
        }
    }
}