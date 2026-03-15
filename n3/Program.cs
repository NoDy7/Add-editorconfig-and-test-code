class TaskManager
{
    // Нарушение 1: кривые отступы (прижато к левому краю)
    private string taskName = "Лаба"; // Нарушение 2: приватное поле без подчеркивания

    public void PrintTask( )
    {
        Console.WriteLine(taskName);
    }
}