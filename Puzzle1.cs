using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
    public static Puzzle1 Instance;

    public GameObject prefabMascara;
    public Transform localParaInstanciar;

    private int ContaObj = 0;
    public bool MascaraCaos = false;


    void Awake()
    {
        Instance = this;
    }

    public void ObjetoClicado()
    {
        ContaObj++;

        if (ContaObj >= 4 && !MascaraCaos)
        {

            InstanciarMascara();
        }
    }
    void InstanciarMascara()
    {
        MascaraCaos = true;
        Instantiate(prefabMascara, localParaInstanciar.position, Quaternion.identity);
        Debug.Log("A Máscara do Caos surgiu!");
    }

    void OnMouseDown()
    {
        if (Puzzle1.Instance != null)
        {

            Puzzle1.Instance.ObjetoClicado();
        }

        gameObject.SetActive(false);


    }
}

