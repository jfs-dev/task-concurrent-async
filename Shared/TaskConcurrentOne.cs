namespace task_concurrent_async.Shared;

public static class TaskConcurrentOne
{
    public static async Task TaskRun()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tarefa 1 iniciada simultaneamente, duração 10s.");
        
        await Task.Delay(10000);
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Tarefa 1 finalizada simultaneamente com sucesso!");
    }    
}