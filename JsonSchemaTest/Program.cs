// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Json.Schema;


var schema = JsonSchema.FromFile("../../../testschema.json");

CheckProperty(schema);

void CheckProperty(JsonSchema currentSchema)
{
    var keywords = currentSchema.Keywords;
    if (keywords == null)
    {
        return;
    }

    foreach (var keyword in keywords)
    {
        if (keyword.Keyword() != PropertiesKeyword.Name) continue;

        var propertiesKeyword = (PropertiesKeyword)keyword;
        foreach (var property in propertiesKeyword.Properties)
        {
            var key = property.Key;
            var value = property.Value;

            Console.WriteLine($"Key: {key}");
            CheckProperty(value);
        }
    }
}