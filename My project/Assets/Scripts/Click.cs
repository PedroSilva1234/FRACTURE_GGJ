using UnityEngine;
public class ClickableObject : MonoBehaviour
{
    [TextArea(3, 10)] //caixa de texto maior no Inspetor da Unity
    public string descricaoDoItem; //texto do item

    public InterectableManager.clickableAction tipoDeInteracao = InterectableManager.clickableAction.inspecao;

    public void Interact()
    {
        InterectableManager manager = Object.FindFirstObjectByType<InterectableManager>();

        if (manager != null)
        {
            manager.ExibirDescricao(descricaoDoItem);
        }
    }

    void OnMouseDown()
    {
        Interact();
        Debug.Log("clique");
    }
}
