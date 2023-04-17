using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageManage : MonoBehaviour
{
    

    public void ChangeLanguage(string language_id)
    {

        Dictionary<string, Locale> languageDictionary = new Dictionary<string, Locale>
        {
            {"en",LocalizationSettings.AvailableLocales.Locales[0]},
            {"em",LocalizationSettings.AvailableLocales.Locales[1]}
        };
            
        if (languageDictionary.ContainsKey(language_id))
        {
            LocalizationSettings.SelectedLocale = languageDictionary[language_id];

        }
    }
}
