using UnityEngine;

public class BarraMovimento1 : MonoBehaviour
{
    public float velocidadeMovimento = 3f; // Velocidade de movimento da barra
    public Vector3 direcaoMovimento = new Vector3(1, 1, 0); // Direção de movimento da barra
    public float distanciaMaxima = 5f; // Distância máxima que a barra pode se mover
    private bool triggerAcionado = false; // Flag para indicar se o trigger está acionado
    private Vector3 posicaoInicial; // Posição inicial da barra

    private void Start()
    {
        posicaoInicial = transform.position; // Salva a posição inicial da barra
    }

    private void Update()
    {
        // Se o trigger estiver acionado e a barra não atingiu a distância máxima, move a barra
        if (triggerAcionado && Vector3.Distance(posicaoInicial, transform.position) < distanciaMaxima)
        {
            transform.Translate(direcaoMovimento * velocidadeMovimento * Time.deltaTime);
        }
        // Se a barra atingiu a distância máxima, retorna a barra para a posição inicial
        else if (Vector3.Distance(posicaoInicial, transform.position) >= distanciaMaxima)
        {
            transform.position = posicaoInicial;
            triggerAcionado = false;
        }
    }

    // Método para ativar a barra
    public void AtivarBarra()
    {
        triggerAcionado = true;
    }

    // Método para desativar a barra
    public void DesativarBarra()
    {
        triggerAcionado = false;
    }
}
