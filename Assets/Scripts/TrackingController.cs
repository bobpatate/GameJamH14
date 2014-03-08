using UnityEngine;

/// <summary>
/// Change la position de l'objet auquel ce script est attaché pour suivre un autre objet.
/// </summary>
public class TrackingController : MonoBehaviour
{
    /// <summary>
    /// La distance respectée par la caméra pour le suivi de l'objet.
    /// </summary>
    public float distance = 10f;

    /// <summary>
    /// Contrôle la rigité de la caméra.
    /// Doit être compris entre 0f (exclu) et 1f (inclu).
    /// 1f = la caméra snap directement à la position cible
    /// 0.1f = la caméra est plutôt rapide
    /// 0.01f = la caméra est plutôt lente
    /// </summary>
    public float rigidity = 0.1f;

    /// <summary>
    /// L'objet suivi par la caméra.
    /// </summary>
    public GameObject target = null;

    void Update()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.transform.position + Vector3.up * distance;

            transform.position = Vector3.Lerp(transform.position, targetPosition, rigidity);
        }
    }
}