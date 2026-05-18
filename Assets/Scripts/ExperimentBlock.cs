using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class ExperimentBlock : MonoBehaviour
{
    private InclinedPlaneExperiment experiment;
    private XRGrabInteractable grab;

    void Start()
    {
        experiment = FindObjectOfType<InclinedPlaneExperiment>();
        grab = GetComponent<XRGrabInteractable>();
        if (grab != null)
        {
            grab.selectEntered.AddListener(OnGrabbed);
            grab.selectExited.AddListener(OnReleased);
        }
    }

    void OnGrabbed(SelectEnterEventArgs args)
    {
        // Можно уведомить эксперимент
    }

    void OnReleased(SelectExitEventArgs args)
    {
        // Возможно, сбросить замеры
    }
}