namespace SQLLike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstboxDataset.Items.Add(txtAdd.Text);
            txtAdd.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstboxResult.Items.Clear();
            Interperter interperter = new Interperter(txtLike.Text);
            List<string> values = new List<string>();
            foreach (string item in lstboxDataset.Items)
            {
                values.Add(item);
            }
            var result = interperter.Interpert(values);
            for (int i = 0; i < values.Count; i++)
            {
                if (result[i])
                    lstboxResult.Items.Add(values[i]);
            }
        }
    }
}
