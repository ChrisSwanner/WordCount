# # Word Counter App

##### By Chris Swanner

## Description

_Allows the user to determine word count from a pair of inputs (input 1 is a single word, input 2 is a sentence to be searched for the frequency of occurrences of input 1)._

## Setup/Installation

_Files can be cloned from https://github.com/chrisswanner/wordCounter and run in a browser (requires a server environment)._

## Specifications
| Behavior | Input Example 1 | Input Example 2 |  Output Example  |
| -------- |:---------------:|:---------------:|:----------------:|:------------------------ |
| Detect occurrence of single letter and identical 2nd input | 'a' | 'a' | Frequency: 1 |
| Detect occurrence of single letter in multiple 2nd input | 'a' | 'a b' | Frequency: 1 |
| Detect increase frequency of occurrences | 'a' | 'a b a' | Frequency: 2 |
| Detect occurrence of single word and identical 2nd input | 'and' | 'and' | Frequency: 1 |
| Detect occurrence of word with multiple 2nd input | 'and' | 'cat and dog' | Frequency: 1 | 
| Detect occurrence of word with case differences | 'hello' | 'Hello there, I say!' | Frequency: 1 |
| Detect occurrence if next to punctuation | 'hello' | 'Hello. I say, hello!' | Frequency: 2 |


## Known Bugs

_None known._

## Technologies Used

_C#, Razor, HTML, CSS,

### License

Copyright (c) 2018 Chris Swanner
