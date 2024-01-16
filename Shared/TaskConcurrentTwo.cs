namespace task_concurrent_async.Shared;

public static class TaskConcurrentTwo
{
    public static async Task TaskRun()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Tarefa 2 iniciada simultaneamente, duração 5s.");
        
        await Task.Delay(5000);
        
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Tarefa 2 finalizada simultaneamente com sucesso!");
    }    
}