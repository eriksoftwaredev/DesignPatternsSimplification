# Simplifying Design Patterns

In software engineering, design patterns provide reusable solutions to common problems in software design within a specific context.


They serve as templates for problem-solving, offering formalized best practices to enhance application and system design.


Object-oriented design patterns depict relationships between classes or objects, remaining adaptable to various situations.


However, patterns involving mutable state may not align with functional programming languages. Recognize that some languages may negate the need for certain patterns, and while object-oriented patterns prevail, they may not suit non-object-oriented languages.


Design patterns offer a structured approach, bridging the gap between programming paradigms and concrete algorithms.

## **GoF Design Patterns:**

The surge in popularity of design patterns in computer science can be traced back to the publication of "Design Patterns: Elements of Reusable Object-Oriented Software" in 1994 by the "Gang of Four" (Gamma et al.), commonly abbreviated as "GoF." The inaugural Pattern Languages of Programming Conference took place that same year, with the establishment of the Portland Pattern Repository for documenting design patterns occurring the following year.

### **Behavioral Patterns:**

**In software engineering, behavioral design patterns refer to patterns that recognize and define common communication interactions among objects. These patterns enhance flexibility in managing communication processes.**

#### **01. Memento**

✅ **The Problem:**

Picture yourself making a text editor app. Apart from basic text editing, your editor can also do things like formatting text and adding pictures within the text.

At one point, you thought it would be good to allow users to undo any changes they make to the text. This feature has become so common that people now assume every app should have it.

**Now, here's the challenge:**<br>
Save the internal state of an object outside, so you can restore the object to that state later.


✅ **The Solution:**

We need to save an object's internal state externally, allowing us to revert to that state when necessary.

![MementoUMLDiagram](https://github.com/eriksoftwaredev/DesignPatternsSimplification/assets/86197661/5bedb8ee-da93-4d1b-a8a8-91d2030436de)

In this example, the Editor class (Originator) manages its state with the help of the inner EditorState class (Memento). The EditorHistory class (Caretaker) keeps track of saved states, allowing for easy undo functionality.

✅ **My Refactored Solution:**

Look at the "[RefactoredSolution](src/GoF/Behavioral/01-Memento/2-Solution/MementoSolution)" project for the Memento Pattern.<br>
I've simplified and enhanced the user experience in the following ways:

- Automatically initializes EditorHistory and CreateState within the Editor class.
- Streamlined the process by automatically handling Push and Pop calls within the Editor class.

<br>
💡 Understanding and implementing the Memento pattern can greatly enhance the flexibility of your applications, especially when it comes to managing and reverting object states.

#### **02. State**

✅ **The Problem:**

✅ **The Solution:**

✅ **My Refactored Solution:**
