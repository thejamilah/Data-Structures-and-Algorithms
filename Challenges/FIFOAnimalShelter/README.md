## .NET C# Educational Whiteboard Assignment

## Learning
Stacks and Queues

## Whiteboard assignment instructions
Comparison

### Problem Domain
Create a method that take a string as its only argument, and return a boolean representing whether or not the brackets in the string are balanced. There are 3 types of brackets:
* Round Brackets : ()
* Square Brackets : []
* Curly Brackets : {}
_Example_ </br>

| Input | Output |
| --- | --- |
| {} | TRUE |
| {}(){} | TRUE |
| ()[[Extra Characters]] | TRUE |
| (){}[[]] | TRUE |
| [({}] | FALSE |
| (]( | FALSE |
| {(}) | FALSE |

_Example Output_ </br>
| Input | Output | Why |
| :---         |     :---:      |          ---: |
| { | FALSE | error unmatched opening { remaining.
| ) | FALSE | error closing ) arrived without corresponding opening.
| } | FALSE | error closing } arrived without corresponding opening.

### Big O
Time: O (1)
Space: O (n)

More on Big O Here:
http://bigocheatsheet.com/

### Whiteboard Solution Images
![whiteboard challenge 13](https://user-images.githubusercontent.com/39015829/47465026-039a8e80-d7a0-11e8-9f20-bd62b09ed2e5.jpg)
