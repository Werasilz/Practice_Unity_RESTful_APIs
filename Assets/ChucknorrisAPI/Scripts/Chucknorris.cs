using UnityEngine;

namespace ChucknorrisAPI
{
    public class Chucknorris : MonoBehaviour
    {
        public void NewJoke()
        {
            Joke joke = APIHelper.GetNewJoke();
            print(joke.value);
        }
    }
}