using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esteira : MonoBehaviour
{
    public float coeficienteDeFriccao = 0.1f; // Ajuste conforme necessário
    public float velocidadeMaxima = 5f; // Ajuste conforme necessário
    public float forcaDeEmpurrao = 10f; // Ajuste conforme necessário
    private bool direcaoReversa = false; // Flag para controlar a direção da segunda caixa

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Caixa2"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                float massaDaCaixa = rb.mass;
                float forca = forcaDeEmpurrao * massaDaCaixa;

                // Determinar a direção do empurrão com base na flag direcaoReversa
                Vector3 direcao = transform.forward;
                if (gameObject.CompareTag("Esteira2"))
                {
                    direcao *= 1f; // Inverter a direção para a segunda esteira quando direcaoReversa é verdadeira
                }

                rb.AddForce(direcao * forca, ForceMode.Force);

                // Limitar a velocidade máxima
                rb.velocity = Vector3.ClampMagnitude(rb.velocity, velocidadeMaxima);
            }
        }
        else
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                float massaDaCaixa = rb.mass;
                float forca = forcaDeEmpurrao * massaDaCaixa;

                // Determinar a direção do empurrão com base na flag direcaoReversa
                Vector3 direcao = transform.forward;
                if (gameObject.CompareTag("Esteira2") && direcaoReversa)
                {
                    direcao *= -1f; // Inverter a direção para a segunda esteira quando direcaoReversa é verdadeira
                }

                rb.AddForce(direcao * forca, ForceMode.Force);

                // Limitar a velocidade máxima
                rb.velocity = Vector3.ClampMagnitude(rb.velocity, velocidadeMaxima);
            }
        }
    }

    void FixedUpdate()
    {
        // Reduzir a velocidade da caixa com base no coeficiente de fricção
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity -= transform.forward * coeficienteDeFriccao * Time.deltaTime;
    }

    // Método para alternar a direção da segunda caixa
    public void AlternarDirecao()
    {
        direcaoReversa = !direcaoReversa;
    }
}