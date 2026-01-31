using TMPro;
using UnityEngine;

public class InterectableManager : MonoBehaviour
{


    public enum clickableAction
    {

        dialogo,
        inspecao,
        encaixe

    }

    [Header("Configuracoes de UI")]
    public GameObject Overlay;
    public TextMeshPro campoDeTexto;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Garante que o jogo comece com a interface escondida
        if (Overlay != null)
        {
            Overlay.SetActive(false);
        }

    }

    public void ExibirDescricao(string texto)
    {
        if (Overlay != null && campoDeTexto != null)
        {
            Overlay.SetActive(true);

            campoDeTexto.text = texto;
        }

    }

    public void FecharTexto() {
    
        if (Overlay != null) Overlay.SetActive(false); 
    }

}
