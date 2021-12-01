using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitReciever : MonoBehaviour
{
    public AudioClip _hitSound;
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // 
        // gameObject.AddComponent<AudioSource>();
        _audioSource = gameObject.GetComponent<AudioSource>();
        _audioSource.clip = _hitSound;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Throw")
        {
            if (!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }
        }
    }
}
