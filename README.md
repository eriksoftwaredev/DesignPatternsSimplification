# Simplifying Design Patterns

## **Behavioral Patterns:**

### **01- Memento**

✅Picture yourself making a text editor app. Apart from basic text editing, your editor can also do things like formatting text and adding pictures within the text.

At one point, you thought it would be good to allow users to undo any changes they make to the text. This feature has become so common that people now assume every app should have it.

**Now, here's the challenge:**<br>
Save the internal state of an object outside, so you can restore the object to that state later.


✅**Solution:**<br>
We need to save an object's internal state externally, allowing us to revert to that state when necessary.

![MementoUMLDiagram](https://github.com/eriksoftwaredev/DesignPatternsSimplification/assets/86197661/5bedb8ee-da93-4d1b-a8a8-91d2030436de)

In this example, the Editor class (Originator) manages its state with the help of the inner EditorState class (Memento). The EditorHistory class (Caretaker) keeps track of saved states, allowing for easy undo functionality.

✅**Refactored Solution:**<br>
Look at the "RefactoredSolution" project for the Memento Pattern.<br>
I've simplified and enhanced the user experience in the following ways:

- Automatically initializes EditorHistory and CreateState within the Editor class.
- Streamlined the process by automatically handling Push and Pop calls within the Editor class.

💡Understanding and implementing the Memento pattern can greatly enhance the flexibility of your applications, especially when it comes to managing and reverting object states.
