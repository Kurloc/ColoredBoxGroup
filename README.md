# ColoredBoxGroup
**Requires Odin Inspector**


## Color Box Groups
* Built-on Boxgroup and allows for coloring, titles and nesting.


## Examples
![image](https://github.com/Kurloc/ColoredBoxGroup/assets/57206908/7c94dac6-362d-4eaa-b912-7b9e15188dc7)


Code Ex
```csharp
using Sirenix.OdinInspector.ColoredBoxGroup;
using UnityEngine;

public class Tester : MonoBehaviour
{
    // Implicit Title from Groupname
    [ColoredBoxGroup("ExampleOne", .76f, .23f, .64f, .98f)]
    public string exampleOne;

    // Explicit Title from Groupname
    [ColoredBoxGroup("ExampleTwo", "ExampleTwo", .1f, .96f, .1f, .3f)]
    public string exampleTwo;

    // Grouped Examples
    [ColoredBoxGroup("ExampleGroup", "ExampleGroup", .1f, .96f, .1f, .3f)]
    public string groupExampleItemOne;
    
    [ColoredBoxGroup("ExampleGroup", "ExampleGroup", .1f, .96f, .1f, .3f)]
    public string groupExampleItemTwo;
    
    // Nested Grouped Examples
    [ColoredBoxGroup("ExampleGroup/NestOne", "ExampleGroupNestOneOne", .1f, .0f, .99f, .3f)]
    public string groupExampleNestItemOneOne;

    [ColoredBoxGroup("ExampleGroup/NestOne", "ExampleGroupNestOneTwo")]
    public string groupExampleNestItemOneTwo;

    [ColoredBoxGroup("ExampleGroup/NestTwo", "ExampleGroupNestTwoOne", .99f, .01f, .0f, .9f)]
    public string groupExampleNestItemTwoOne;
    
    [ColoredBoxGroup("ExampleGroup/NestTwo", "ExampleGroupNestTwoTwo")]
    public string groupExampleNestItemTwoTwo;
}
```

## Usage
This code is not currently namedspaced, but you should place it where you're storing all of the scripts for your game/project. Then namespace it accordingly and import then use the attribute.
