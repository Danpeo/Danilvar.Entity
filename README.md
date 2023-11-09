# Base entity for Domain Driven Design

Usage:

```
public class Bakugan : Entity
{
    public string Name { get; set; }

    public string ElementalAttribute { get; set; }

    public int PowerLevel { get; set; }

    public Bakugan(string name, string elementalAttribute, int powerLevel)
    {
        Name = name;
        ElementalAttribute = elementalAttribute;
        PowerLevel = powerLevel;
    }
}
```
