using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using Random = UnityEngine.Random;
public enum SoundEffects
{
	
};
public class AudioManager : MonoBehaviour
{
    public static AudioManager main;

	[SerializeField] private AudioMixer musicMixer = null;
	[SerializeField] private AudioMixer sfxMixer = null;
	
	public float musicVolume;
	public float sfxVolume;
	
	[Space] [Header("Music")] 
	public AudioClip MainMenuMusic;
	public AudioClip[] MainGameMusic;
	[SerializeField] private bool isInMainMenuScene;
	[Space] [Header("Sounds")] 
	
	public AudioClip hit;
	
	[Space][Header("Audio Sources")] 
	public AudioSource musicSource;
	public AudioSource sfxSource;

	#region Properties

	public float MusicVolume
	{
		get => musicVolume;
		set => musicVolume = value;
	}

	public float SfxVolume
	{
		get => sfxVolume;
		set => sfxVolume = value;
	}

	public AudioMixer MusicMixer
	{
		get => musicMixer;
	}

	public AudioMixer SfxMixer
	{
		get => sfxMixer;
	}

	#endregion

	private void Awake()
	{
		main = this;
		GetMixerVolumes();
	}

	private void Start()
	{
		StartCoroutine(musicLoop(isInMainMenuScene));
	}

	private void GetMixerVolumes()
	{
		musicMixer.GetFloat("MusicVolume", out musicVolume);
		sfxMixer.GetFloat("SfxVolume", out sfxVolume);
	}

	private void Update()
	{
		//if (Input.GetMouseButtonDown(0)) PlaySoundEffect(SoundEffects.click);
	}

	public void PlaySoundEffect(SoundEffects effect)
	{
		
		switch (effect)
		{
			//case SoundEffects.click:
			//	sfxSource.PlayOneShot(click[Random.Range(0, click.Length)]);
			//	break;
			//case SoundEffects.Eat:
			//	sfxSource.PlayOneShot(eat);
			//	StartCoroutine(sound(eat.length));
			//	break;
		}
		
	}

	IEnumerator sound(float time)
	{
		yield return new WaitForSeconds(time);
	}

	IEnumerator musicLoop(bool mainMenu)
	{
		int current = 0;
		if (!mainMenu)
		{
			yield return new WaitForSeconds(2.5f);
		}
		while (gameObject.activeSelf)
		{
			if (!musicSource.isPlaying)
			{
				if (!mainMenu)
				{
					current++;
					if (current >= MainGameMusic.Length)
					{
						current = 0;
					}
					musicSource.clip = MainGameMusic[Random.Range(0,3)];
				}
				else
				{
					musicSource.clip = MainMenuMusic;
				}

				musicSource.Play();
			}
			yield return new WaitForEndOfFrame();
		}
	}
}
