namespace InterfaceSegregationPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


         
    }



    public interface IDatabaseManager
    {
        void Add();
        void Remove();
        void Update();
    }

    public interface IDatabseRemoveAll : IDatabaseManager
    {
        void RemoveAll(int[] id);
    }


    public class MyClass : IDatabseRemoveAll
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }

        public void RemoveAll(int[] id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
