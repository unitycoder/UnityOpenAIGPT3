namespace UnityLibrary
{
    [System.Serializable]
    public class RequestData
    {
        public string model;
        public string prompt;
        public float temperature;
        public int max_tokens;
        public int top_p;
        public int frequency_penalty;
        public int presence_penalty;
    }

    [System.Serializable]
    public class OpenAIAPI
    {
        public string id;
        public string @object;
        public int created;
        public string model;
        public Choice[] choices;
        public Usage usage;
    }

    [System.Serializable]
    public class Choice
    {
        public string text;
        public int index;
        public object logprobs;
        public string finish_reason;
    }

    [System.Serializable]
    public class Usage
    {
        public int prompt_tokens;
        public int completion_tokens;
        public int total_tokens;
    }
}
