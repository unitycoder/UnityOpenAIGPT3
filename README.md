# Unity OpenAI API

### USAGE
- Get your API key from https://beta.openai.com/account/api-keys
- Save your API key into "StreamingAssets/secretkey.txt" (or other path and modify the api key loading path)
- Play main.scene, test some prompt (currently uses "Completions" API only)

### SETTINGS
See "#Scripts" gameobject, it has model name variable<br>
![image](https://user-images.githubusercontent.com/5438317/211652157-7d3639c4-6f27-48f0-ad7c-0bb9fa6276b7.png)<br>
Rest of the settings are currently hard-coded in the OpenAI.cs Execute() method, where it fill the POST request json data.<br>
![image](https://user-images.githubusercontent.com/5438317/211652664-aa27d8dc-1e5e-4642-aed6-351d1402cf7e.png)

### IMAGES
![image](https://user-images.githubusercontent.com/5438317/211652295-d043dcb6-f702-4ea1-8e08-bcf8f201e1f8.png)


### Website
https://unitycoder.com/blog/2023/01/10/using-openai-api-with-webrequest-from-unity/
