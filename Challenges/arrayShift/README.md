# Array Shift

## Insert and Shift Middle Index of an Array 

## Problem Domain
Write a method called ArrayShift() which takes in an array and the value to be added. Withoud using any built-in methods, return an array with the given value added at the middle index.

## Example Input
{2,4,6,8}, 5

## Example Output
{2,4,5,6,8}

## Approach & Efficiency 
#### Big O
Time = O(n)</br>
Time is O (n) because the iteration through the array of n number of elements.</br>
Big O Space = O(n)</br>
Space is O (n) because of the instantiation of a new array with n number of elements in order to insert the new value.</br>
 
 ## Algorithm
 * Inside Main() instantiate input array
 * Declare input value as midNum
 * Outside of Main()
 * Instatiate method that accepts the input array and midNum as argurments ShiftArray(int[] array, int midNum)
 * Instantiate a new array of input array size + 1
 * instantiate a counters equal to 0
 * Using decimal to account for unenen array size determine midIndex of input array decimal midIndex = Math.Ceiling((decimal)(array.Lenghth) / 2)
 * using a for loop, iterate through neew array length  by incrementing the variable for (int i = 0; i < newArray.Length; i++)
 * if midIndex equals i during iteration 
 * assign the new array at variable equal to midNum
 * else
 * set new array at variable index equal to input array at index counter incremented
 * return newArray
 
 **Insert Shift Array Whiteboard**
![arrayshift](https://user-images.githubusercontent.com/39015829/50411297-c6f50e80-07b3-11e9-9022-3053fefbbb01.jpg)
