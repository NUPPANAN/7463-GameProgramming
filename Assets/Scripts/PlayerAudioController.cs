using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioPlayer audioPlayer;
    
    [Header("Audio Clips")]
    [SerializeField] private SoAudioClips walkAudioClips;
    [SerializeField] private SoAudioClips jumpAudioClips;
    [SerializeField] private SoAudioClips deathAudioClips;
    [SerializeField] private ParticleSystem walkParticle;
    [SerializeField] private ParticleSystem fallParticle;

    public void PlayJump()
    {
        audioPlayer.PlaySound(jumpAudioClips, 0.5f);
    }

    public void PlayWalk()
    {
        audioPlayer.PlaySound(walkAudioClips, 0.3f);
        Instantiate(walkParticle, transform.position, transform.rotation);
    }

    public void PlayFallImpact()
    {
        audioPlayer.PlaySound(walkAudioClips, 0.6f);
        Instantiate(fallParticle, transform.position, transform.rotation);
    }

    public void PlayDeath()
    {
        audioPlayer.PlaySound(deathAudioClips);
    }
    
    public void MuteAudioSource()
    {
        audioPlayer.MuteAudioSource();
    }
}
