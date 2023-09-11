namespace People;

public partial class App : Application
{
    // TODO: Add a public static PersonRepository property

    public static PersonRepository PersonRepo { get; private set; }

    public App(PersonRepository repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        // TODO: Initialize the PersonRepository property with the PersonRepository singleton object
        PersonRepo = repo;
    }
}