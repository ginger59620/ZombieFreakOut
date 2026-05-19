using UnityEngine;
public class ArmFollowCursor : MonoBehaviour
{
    [Header("Right Side Angles")]
    public float maxAngle = 10f;
    public float minAngle = -10f;

    [Header("Left Side Angles")]
    public float leftMaxAngle = 10f;
    public float leftMinAngle = -10f;
    
    void Update()
    {
        // Apanaha a posição do rato no ecrã
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calcula a direção 
        Vector3 direction = mousePos - transform.position;
        direction.z = 0f;

        // Encontra o angulo de diferença
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Checkar se o rato está no lado Direito (Right Side)

        
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
