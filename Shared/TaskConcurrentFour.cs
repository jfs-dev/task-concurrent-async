namespace task_concurrent_async.Shared;

public static class TaskConcurrentFour
{
    public static async Task TaskRun()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Tarefa 4 iniciada simultaneamente, duração 8s.");
        
        await Task.Delay(8000);
        
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Tarefa 4 finalizada simultaneamente com sucesso!");
    }    
}