using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

/// <summary>
/// Anzeige von verschiedenen AR spezifischen Eigenschaften im UI
/// </summary>
public class ARController : MonoBehaviour
{
    // Textfelder für Ausgabe
    public TextMeshProUGUI ScaleFactorLabel;
    public TextMeshProUGUI DistanceLabel;

    // Transform des ImageTargets (Marker)
    public Transform ImageTargetTransform;

    // Skalierungsfaktor
    private float _initalScaleFactor;
    private float _currentScaleFactor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _initalScaleFactor = VuforiaConfiguration.Instance.Vuforia.VirtualSceneScaleFactor;
        _currentScaleFactor = _initalScaleFactor;
    }

    // Update is called once per frame
    void Update()
    {
        // Distanz zwischen Kamera und Marker berechnen
        float distance = Vector3.Distance(transform.position, ImageTargetTransform.position);
        Debug.Log(distance);
        DistanceLabel.text = distance / _currentScaleFactor + " m";
    }

    /// <summary>
    /// Verändern des Virtual Scene Scale 
    /// </summary>
    /// <param name="scale"></param>
    public void SetSceneScale(float scale) 
    {
        _currentScaleFactor = _initalScaleFactor / scale;
        VuforiaConfiguration.Instance.Vuforia.VirtualSceneScaleFactor = _currentScaleFactor;

        ScaleFactorLabel.text = "1 : " + _currentScaleFactor;
    }
}
