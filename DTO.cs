namespace fluentnestedtest;

public sealed record Thing(string Name, Characteristics Characteristics);

public record Characteristics(string Color, int Count);