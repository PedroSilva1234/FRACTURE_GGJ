using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueController : MonoBehaviour
{
    public static DialogueController instance;

    [Header("UI")]
    public GameObject dialogueObj; // Arraste o objeto 'Dialog' aqui
    public Image profile;
    public TMP_Text speechText;    // Arraste o objeto 'text' aqui
    public TMP_Text actorNameText; // Arraste o objeto 'speech' aqui

    private void Awake()
    {
        // Garante que só exista um controlador na cena
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
    }

    private void Start()
    {
        // PARTE 1: Faz a caixa de texto iniciar fechada
        if (dialogueObj != null)
        {
            dialogueObj.SetActive(false);
        }
    }

    public void Speech(Sprite p, string txt, string actorName)
    {
        if (dialogueObj == null) return;

        dialogueObj.SetActive(true);
        if (speechText != null) speechText.text = txt;
        if (actorNameText != null) actorNameText.text = actorName;

        if (profile != null)
        {
            if (p != null)
            {
                profile.gameObject.SetActive(true);
                profile.sprite = p;
            }
            else profile.gameObject.SetActive(false);
        }
    }

    public void CloseDialogue()
    {
        if (dialogueObj != null) dialogueObj.SetActive(false);
    }
}