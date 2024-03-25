using UnityEngine;

public class PalhetaRotator : MonoBehaviour
{
    public float velocidadeRotacao = 30f; // Velocidade de rotação da palheta
    public float anguloMaximo = 30f; // Angulo máximo de rotação da palheta
    public float anguloMinimo = 30f; // Angulo mínimo de rotação da palheta
    private bool palhetaAtivada = false; // Flag para controlar se a palheta está ativada

    private void Update()
    {
        // Se a palheta estiver ativada e não estiver no ângulo máximo, rotaciona a palheta gradualmente no sentido positivo
        if (palhetaAtivada && transform.rotation.eulerAngles.y < anguloMaximo)
        {
            transform.Rotate(Vector3.up * velocidadeRotacao * Time.deltaTime);
        }
        // Se a palheta não estiver ativada e não estiver no ângulo mínimo, rotaciona a palheta gradualmente no sentido negativo
        else if (!palhetaAtivada && transform.rotation.eulerAngles.y > 0f )
        {
            transform.rotation = Quaternion.identity;
        }
    }

    // Método para ativar a palheta
    public void AtivarPalheta()
    {
        palhetaAtivada = true;
    }

    // Método para desativar a palheta
    public void DesativarPalheta()
    {
        palhetaAtivada = false;
    }
}
