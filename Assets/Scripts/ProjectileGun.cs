using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ProjectileGun : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _fireImpulse = 20f;

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    private void FireBullet(ActivateEventArgs arg)
    {
        GameObject newBullet = Instantiate(_bullet);
        newBullet.transform.position = _spawnPoint.position;
        newBullet.transform.forward = _spawnPoint.forward;
        newBullet.GetComponent<Rigidbody>().velocity = _spawnPoint.forward * _fireImpulse;
        Destroy(newBullet, 5f);
    }
}