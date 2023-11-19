namespace DependencyInversionPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DatabaseManager sendEmail = new DatabaseManager(new EmailNotification());

            DatabaseManager sendSMS = new DatabaseManager(new SMSNotification());
        }
    }



}

public interface INotification
{
    void Send(string message);
}
public class EmailNotification:INotification
{
    public void Send(string message)
    {
        //TODO: Send Message
    }
}
public class SMSNotification : INotification
{
    public void Send(string message)
    {
        //TODO: Send SMS
    }
}


public class DatabaseManager
{
    private INotification _notification;

    public DatabaseManager(INotification notification)
    {
        _notification = notification;
    }

    public void Add()
    {
        _notification.Send("Add New Record");
    }
    public void Update()
    {
        _notification.Send("Update Record");
    }
    public void Remove()
    {
        _notification.Send("Remove Record");
    }
}