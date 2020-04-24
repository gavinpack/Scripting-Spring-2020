using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Health : MonoBehaviour
{
    public int healthValue = 10;
    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        healthValue--;
        if (healthValue > 0)
            return;
        
        sound.Play();
        Destroy(gameObject, 0.5f);
    }
}
