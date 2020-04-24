using UnityEngine;
using UnityEngine.Events;

public class Shooter : MonoBehaviour
{
    public GameObject ammo;
    public AudioSource sound;
    public UnityEvent fireEvent;
    private Vector2 mouseLocation;
    

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fireEvent.Invoke();
        }
    }

    public void Shot()
    {
        var ammoTransform = transform;
        Instantiate(ammo, ammoTransform.position, ammoTransform.rotation);
        sound.Play();
    }

    public void AimAndShot()
    {
        mouseLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var instance = Instantiate(ammo, transform.position, Quaternion.identity);
        instance.transform.LookAt(mouseLocation);
    }
}
