using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

namespace PokeAPI
{
    public class PokemonAPI : MonoBehaviour
    {
        private const string API_URL = "https://pokeapi.co/api/v2/pokemon/{POKEMON_NAME}";

        public void GetPokemon()
        {
            string pokemonName = "pikachu"; // Replace with the desired Pokemon name

            string url = API_URL.Replace("{POKEMON_NAME}", pokemonName.ToLower());
            StartCoroutine(GetPokemonData(url));
        }

        private IEnumerator GetPokemonData(string url)
        {
            UnityWebRequest request = UnityWebRequest.Get(url);

            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string responseText = request.downloadHandler.text;
                Debug.Log("API response: " + responseText);
                // Process the Pokemon data here
            }
            else
            {
                Debug.Log("API request failed: " + request.error);
            }
        }
    }
}
