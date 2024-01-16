using task_concurrent_async.Shared;

await Task.WhenAll
(
    TaskConcurrentOne.TaskRun(),
    TaskConcurrentTwo.TaskRun(),
    TaskConcurrentThree.TaskRun(),
    TaskConcurrentFour.TaskRun()
);