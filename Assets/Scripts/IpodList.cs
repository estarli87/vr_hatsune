using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IpodList : MonoBehaviour
{
   [SerializeField] private AudioClip[] list_ipod;
   [SerializeField] private AudioClip bg_sound;
   
   [SerializeField] private Sprite[] list_images;

   [SerializeField] private int index;
   
   [SerializeField] private GameObject changeImage;
    // Start is called before the first frame update
    void Awake()
    {
        index = 0;
        bg_sound = GetComponent<AudioSource>().clip;
    }

    public void ChangeMusic()
    {
        index++;
        
        if (index >= list_images.Length)
        {
            index = 0;
        }
        
        GetComponent<AudioSource>().clip = list_ipod[index];
        changeImage.GetComponent<Image>().sprite = list_images[index];
        GetComponent<AudioSource>().Play();
        
    }
    public void PlayMusic()
    {
        if (!GetComponent<AudioSource>().isPlaying || GetComponent<AudioSource>().clip != bg_sound)
        {
            GetComponent<AudioSource>().Play();
        }
       
    }
    
    public void PauseMusic()
    {
        GetComponent<AudioSource>().Pause();
    }
    
    public void StopMusic()
    {
        if (GetComponent<AudioSource>().clip != bg_sound)
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().clip = bg_sound;
            StartCoroutine(WaitForFunction());
        }
        

    }
    
    // ReSharper disable Unity.PerformanceAnalysis
    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(0.6f);
        GetComponent<AudioSource>().Play();
    }
}
