using UnityEngine;

public class ExhibitProximity : MonoBehaviour
{
    public GameObject infoPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("MainCamera"))
            infoPanel.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("MainCamera"))
            infoPanel.SetActive(false);
    }
}