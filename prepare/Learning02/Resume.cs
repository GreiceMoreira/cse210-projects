public class Resume{
    public string _userName = "";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_userName}");
        Console.WriteLine($"Jobs:");
       
        foreach (Job job in _jobs){
            job.DisplayJobDetails();
        }


    
    }

}