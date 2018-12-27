# Repeted Word

## Problem Domain
Write a method that accepts a lengthy string parameter. This method should utilize a hash table to determine if any words in the input string are repeated. After the method determines the first repeated word it should return that word as a string.</br>

### Approach & Efficiency 
Time: O (n) </br>
This iterates over an array of strings to check if the strings exist in a hash table and add them to the hash table if they do not exist.
Space: O (n) </br>
This method requires the instantiation of a new hash table and a string array. Therefore additional space is needed.

More on Big O Here:
http://bigocheatsheet.com/ </br>

