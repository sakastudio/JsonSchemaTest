// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Json.Schema;


var schema = JsonSchema.FromFile("../../../testschema.json");

Console.WriteLine(schema != null ? "Schema loaded successfully" : "Failed to load schema");
