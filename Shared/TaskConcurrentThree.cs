namespace task_concurrent_async.Shared;

public static class TaskConcurrentThree
{
    public static async Task TaskRun()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Tarefa 3 iniciada simultaneamente, duração 3s.");
        
        await Task.Delay(3000);
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Tarefa 3 finalizada simultaneamente com sucesso!");
    }    
}