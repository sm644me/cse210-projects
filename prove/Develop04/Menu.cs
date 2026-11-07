// Define a Menu class, which will be used to
// display and allow users to select from options.
public class Menu
{
    // Member variables begin with an underscore.
    // Menus have lists of options and actions.
    // These lists must correspond 1-to-1.
    private List<string> _options = new List<string>();
    private List<Action> _actions = new List<Action>();

    // Constructor method.
    public Menu(List<string> options, List<Action> actions)
    {
        _options = options;
        _actions = actions;
    }

    // Pick an option and run it.
    public void DisplayAndRun()
    {
        int i = 0;
        Console.WriteLine("\nPlease select one of the following choices:");
        foreach (string o in _options)
        {
            i += 1;
            Console.WriteLine($"{i}. {o}");
        }

        // When getting the user's response, subtract 1 so it
        // will align with the list of actions.
        Console.Write("What would you like to do? ");
        int response = int.Parse(Console.ReadLine()) - 1;
        _actions[response]();
    }
}