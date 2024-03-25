using UnityEngine;

public class MeuTrigger3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Caixa3"))
        {
            PalhetaRotator palhetaRotator = FindObjectOfType<PalhetaRotator>();
            if (palhetaRotator != null)
            {
                palhetaRotator.AtivarPalheta();
                
            }
            BarraMovimento3 barramovimento3 = FindObjectOfType<BarraMovimento3>();
            if (barramovimento3 != null)
            {
                barramovimento3.AtivarBarra();
                
            }
        }
        else
        {
            PalhetaRotator palhetaRotator = FindObjectOfType<PalhetaRotator>();
            if (palhetaRotator != null)
            {
                palhetaRotator.DesativarPalheta();
            }
            BarraMovimento3 barramovimento3 = FindObjectOfType<BarraMovimento3>();
            if (barramovimento3 != null)
            {
                barramovimento3.DesativarBarra();
                
            }
        }
    }
}
