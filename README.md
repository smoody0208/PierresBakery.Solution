# Pierre's Bakery, Week 8 Project

#### Latest version date 2020/07/17

#### By Spencer Moody

## Description
This is a console based application that allows a user to order bread/pastries and returns their total price.

## Specifications

1. **Behavior:** The program will first greet the user welcoming them to "Pierre's Bakery".
    * **Input Example:** --
    * **Output Example:** "Welcome to Pierre's Bakery, the best in the world"

2. **Behavior:** The program will prompt the user to select if they would like to order Bread or a Pastery.
    * **Input Example:** --
    * **Output Example:** "Would you like to order some bread? buy 2, get 1 free. A single loaf costs $5.!" or "Would you like to order a pastery? Buy 1 for $2 or 3 for $5."

3. **Behavior:** The program will ask the user to order their desiered amount of bread or pasteries and add the total.
    * **Input Example:** "3 loafs of bread"
    * **Output Example:** "Total: $5"

2. **Behavior:** The program will then ask the user if they wish to add additional items to their order or checkout.
    * **Input Example:** "additional items"
    * **Output Example:** Back to main menu

2. **Behavior:** If the user selects "checkout" they will be given their order total.
    * **Input Example:** "checkout"
    * **Output Example:** "Total: $5"

## Setup and Installation

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## Bugs

No bugs

## Tech used

* C#
* .NET

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Spencer Moody
