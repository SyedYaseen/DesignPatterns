namespace DesignPatterns.StatePattern;

public interface ITool
{
    //The tools have two states that they can be in
    //I can more states if I want to
    
    //This could also be an abstract class
    //Since there is no common code that I need to share with the 
    //children of this class, this can be an interface
    void mouseUp();
    void mouseDown();
}