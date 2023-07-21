using UnityEngine;

namespace Sirenix.OdinInspector.ColoredBoxGroup
{
    public class Examples : MonoBehaviour
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
}
