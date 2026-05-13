using UnityEngine;

public class ArmFollowCursor : MonoBehaviour
{
    void Update()
    {
        // Apnaha a posição do rato no ecrã
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Calcula a direção 
        Vector3 direction = mousePos - transform.position;
        direction.z = 0f;

        // Encontra o angulo de diferença
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Aplica o angulo ao objeto, rodando-o para o rato
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
