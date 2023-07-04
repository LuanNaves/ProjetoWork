using System.Collections.Generic;

public static class CategoryMapper {
    private static readonly Dictionary<string, string> PortugueseToEnglishMap = new Dictionary<string, string>()
    {
        { "Casa", "House" },
        { "Automotivo", "Automotive" },
        { "Saúde", "Health" },
        { "Beleza", "Beauty" },
        { "Festa", "Party" },
        { "Pet", "Pet" },
    };

    public static string MapToEnglish(string portugueseName) {
        if (PortugueseToEnglishMap.TryGetValue(portugueseName, out var englishName)) {
            return englishName;
        }

        // Se o mapeamento não for encontrado, retorne o nome em português original
        return portugueseName;
    }
}
