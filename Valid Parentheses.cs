using System.Collections;

//Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

//An input string is valid if:

//Open brackets must be closed by the same type of brackets.
//Open brackets must be closed in the correct order.
//Every close bracket has a corresponding open bracket of the same type.

public class Solution
{
    public bool IsValid(string s)
    {
        //Map opening brackets to their corresponding closing brackets
        var parenthesesDictionary = new Dictionary<char, char>()
        {
            {'[', ']'},
            {'(', ')'},
            {'{', '}'}
        };

        // Create stack to keep track of expected closing brackets
        var endings = new Stack<char>();

        // Iterate over each character in input
        foreach (var current in s)
        {
            // If character is opening bracket
            if (parenthesesDictionary.ContainsKey(current))
            {
                // Push closing bracket onto the stack
                endings.Push(parenthesesDictionary[current]);
            }
            // If character is closing bracket
            else if (endings.Count == 0 || endings.Pop() != current)
            {
                return false;
            }
        }
        return endings.Count == 0;
    }
}
