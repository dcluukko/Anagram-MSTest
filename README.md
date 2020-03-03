# _Anagram_

#### _C# Testing practice for Epicodus_, _Mar. 3, 2020_

#### By _**Michelle Morin, Dana Luukko**_

## Description

_This application allows a user to enter a word and a list of words that may be anagrams. An anagram is a word whose letters can be rearranged to become a new word (e.g., "bread" is an anagram of "beard"). After the user enters the list of words, the application returns which (if any) of the words were anagrams._

## Specifications:

| Specification | Example Input | Example Output |
| ------------- |:-------------:| -------------------:|
| Application allows a user to enter a word and constructs an Anagram instance | "bread" | new instance of Anagram created with "bread" as property |
| Application allows a user to enter a sequence of words and constructs an anagram with the initial input word and sequence of words | "bread"; "beard" | Application forms anagram instance with "bread" word property and "beard" wordlist property |
| Application converts each word in word list (array output of GetWordList() method) into a character array | List<string> = { "beard" } | GetWordListChars(); returns { 'b', 'e', 'a', 'r', 'd' } |
| Application sorts character array of input word (alphabetically) | "bread" | { 'a', 'b', 'd', 'e', 'r' } |
| Application sorts character array of each word in input word list (alphabetically) | "beard" | { 'a', 'b', 'd', 'e', 'r' } |
| Application returns true or false for whether or not input words are an anagram by comparing the index of the sorted input word char array to the char array of each word in the word list | { 'a', 'b', 'd', 'e', 'r' }, { 'a', 'b', 'd', 'e', 'r' } | true |

## Setup/Installation Requirements

### Install .NET Core

#### on macOS:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer) to download a .NET Core SDK from Microsoft Corp._
* _Open the file (this will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.)_

#### on Windows:
* _[Click here](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer) to download the 64-bit .NET Core SDK from Microsoft Corp._
* _Open the .exe file and follow the steps provided by the installer for your OS._

#### Install dotnet script
_Enter the command ``dotnet tool install -g dotnet-script`` in Terminal (macOS) or PowerShell (Windows)._

### Clone this repository

_Enter the following commands in Terminal (macOS) or PowerShell (Windows):_
* ``cd desktop``
* ``git clone`` followed by the URL to this repository.
* ``cd`` followed by the repository name.

_Confirm that you have navigated to the correct directory (e.g., by entering the command_ ``pwd`` _in Terminal)._

_Run this console application by entering the following command in Terminal (macOS) or PowerShell (Windows):_
* ``dotnet run``

_To view/edit the source code of this application, open the contents of this directory in a text editor or IDE of your choice (e.g., to open all contents of the directory in Visual Studio Code on macOS, enter the command_ ``code .`` _in Terminal)._

## Technologies Used
* _Git_
* _C#_
* _.NET Core 2.2_
* _dotnet script_

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Michelle Morin, Dana Luukko_**