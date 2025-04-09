using Unity.VisualScripting;
using UnityEngine;

public class MIniMapaScript : MonoBehaviour
{
    [SerializeField] Transform player;

    private void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, player.position.z);
    }
}
