using UnityEngine;

public class MeuTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caixa"))
        {
            PalhetaRotator palhetaRotator = FindObjectOfType<PalhetaRotator>();
            if (palhetaRotator != null)
            {
                palhetaRotator.AtivarPalheta();
                
            }
            BarraMovimento1 barramovimento1 = FindObjectOfType<BarraMovimento1>();
            if (barramovimento1 != null)
            {
                barramovimento1.AtivarBarra();
                
            }
        }
        else
        {
            PalhetaRotator palhetaRotator = FindObjectOfType<PalhetaRotator>();
            if (palhetaRotator != null)
            {
                palhetaRotator.DesativarPalheta();
            }            
            BarraMovimento1 barramovimento1 = FindObjectOfType<BarraMovimento1>();
            if (barramovimento1 != null)
            {
                barramovimento1.DesativarBarra();
                
            }
        }
    }
}
