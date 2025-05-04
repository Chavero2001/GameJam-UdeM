using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource noiseSource;
    [SerializeField] AudioSource SFXSource;

    [Header("----- Audio Clip -----")]
    public AudioClip background;
    public AudioClip schoolNoise;
    public AudioClip book;
    public AudioClip pencil;
    private void Start()
    {
        musicSource.clip = background;
        noiseSource.clip = schoolNoise;
        musicSource.Play();
        noiseSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
    