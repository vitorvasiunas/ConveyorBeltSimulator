using UnityEngine;

public class MeuTrigger2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caixa2"))
        {
            PalhetaRotator palhetaRotator = FindObjectOfType<PalhetaRotator>();
            if (palhetaRotator != null)
            {
                palhetaRotator.AtivarPalheta();
                
            }
            BarraMovimento2 barramovimento2 = FindObjectOfType<BarraMovimento2>();
            if (barramovimento2 != null)
            {
                barramovimento2.AtivarBarra();
                
            }
        }
        else
        {
            PalhetaRotator palhetaRotator = FindObjectOfType<PalhetaRotator>();
            if (palhetaRotator != null)
            {
                palhetaRotator.DesativarPalheta();
            }            
            BarraMovimento2 barramovimento2 = FindObjectOfType<BarraMovimento2>();
            if (barramovimento2 != null)
            {
                barramovimento2.DesativarBarra();
                
            }
        }
    }
}
