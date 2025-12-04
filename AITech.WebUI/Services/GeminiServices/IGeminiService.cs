namespace AITech.WebUI.Services.GeminiServices
{
    public interface IGeminiService
    {
        Task<string> GetGeminiDataAsync(string prompt);
    }
}
