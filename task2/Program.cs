package taskscheduler;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;
import java.util.Timer;
import java.util.TimerTask;
class Task
{
    private String title;
    private Date dueDate;
    private Priority priority;
    public Task(String title, Date dueDate, Priority priority)
    {
        this.title = title;
        this.dueDate = dueDate;
        this.priority = priority;
    }
    public String gettitle()
    {
        return title;
    }
    public Date getduedate()
    {
        return dueDate;
    }
    public Priority getpriority()
    {
        return priority;
    }

}
enum Priority
{
    LOW,
    MEDIUM,
    HIGH
}
class TaskManager
{
    private List<Task> tasks;
    public TaskManager()
    {
        this.tasks = new ArrayList<>();
    }
    public void addTask(Task task)
    {
        tasks.add(task);
    }
    public List<Task> getTask()
    {
        return tasks;
    }
}
class NotificationService
{
    public void sendNotification(String message)
    {
        System.out.println("notification:" + message);
    }
}
public class TaskschedulerApp
{
    public static void main(String[] args)
    {
        TaskManager taskManager = new TaskManager();
        NotificationService notificationService = new notificationService();
        taskManager.addTask(new Task("Task1 is ", new Date(), Priority.MEDIUM));
        taskManager.addTask(new Task("Task2 is ", new Date(), Priority.HIGH));
        taskManager.addTask(new Task("Task3 is ", new Date(), Priority.LOW));
        Timer timer = new Timer();
        for (Task task:taskManager.getTasks())
        {
            timer.schedule(new TimerTask(){
                @override
                public void run()
            {
                notificationService.sendNotification("due date for task'" + task.getTitle() + "'reached.");
            }

        },task.getDueDate());
    }
        try{
            Thread.sleep(5000);
 
        }catch(InterruptedException e){
    e.printStackTrace();
}
         }
}