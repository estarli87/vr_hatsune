using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageManage : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine(Coroutine_Delay());
        
        if (PlayerPrefs.HasKey("currentLanguage"))
        {
            PlayerPrefs.GetString("currentLanguage");
        }
    }

    public void ChangeLanguage(string language_id)
    {
        Dictionary<string, Locale> languageDictionary = new Dictionary<string, Locale>
        {
            {"en",LocalizationSettings.AvailableLocales.Locales[0]},
            {"es-ES",LocalizationSettings.AvailableLocales.Locales[1]}
        };
            
        if (languageDictionary.ContainsKey(language_id))
        {
            LocalizationSettings.SelectedLocale = languageDictionary[language_id];
        }
        PlayerPrefs.SetString("currentLanguage", language_id);

    }
    IEnumerator Coroutine_Delay()
    {
        yield return new WaitForSeconds(0.1f);
        ChangeLanguage(PlayerPrefs.GetString("currentLanguage", "en"));
    }
}
