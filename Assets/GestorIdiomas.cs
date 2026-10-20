using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class GestorIdiomas : MonoBehaviour
{
    private bool cambiandoIdioma = false;

    public void CambiarIdioma(int indiceIdioma)
    {
        if (cambiandoIdioma) return;
        StartCoroutine(RutinaCambioIdioma(indiceIdioma));
    }

    private IEnumerator RutinaCambioIdioma(int indiceIdioma)
    {
        cambiandoIdioma = true;
        // Espera a que el sistema de Localization esté listo
        yield return LocalizationSettings.InitializationOperation;

        // Cambia el idioma según el índice (0 o 1)
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[indiceIdioma];
        cambiandoIdioma = false;
    }
}