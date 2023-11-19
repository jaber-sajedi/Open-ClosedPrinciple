namespace LiskovSubstitutio_Principle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CollectionBase array = new Array();
            IList list = new List();
            list.Add(3);

        }


        public interface IList
        {
            void Add(object item);
        }

        public class CollectionBase
        {
            public int Count { get; set; }
        }
         public class Array : CollectionBase

        {

        }

        public class List : CollectionBase, IList
        {
            public void Add(object item)
            {
                throw new NotImplementedException();
            }
        }
    }
}
