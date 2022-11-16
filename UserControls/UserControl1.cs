using System.Data;

namespace UserControls
{
    public partial class UserControl1 : UserControl
    {

        public string SelectedText
        {
            get { return cmbState.Text; }
        }
        public string SelectedValue
        {
            get { return cmbState.SelectedValue.ToString(); }
        }
        public event EventHandler SelectedIdexChanged;
        public UserControl1()
        {
            InitializeComponent();
            this.Load += new EventHandler(UserControl1_load);
            this.cmbState.SelectedIndexChanged += new EventHandler(cmbState_SelectedIndexChanged);
        }

        void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SelectedIdexChanged != null)
                SelectedIdexChanged(sender, e);
        }
        void UserControl1_load(object sender, EventArgs e)
        {
            BlindComboBox();
        }
        private void BlindComboBox()
        {
            DataTable dtState = new System.Data.DataTable();
            dtState.Columns.Add("txtPart");
            dtState.Columns.Add("valuePart");
            dtState.Rows.Add("Chishtian", "1");//Here Delhi is txtPart and 1 is valuepart  
            dtState.Rows.Add("Faisalabab", "2");
            dtState.Rows.Add("Punjab", "3");
            dtState.Rows.Add("Sindh", "4");
            cmbState.DataSource = dtState;
            cmbState.DisplayMember = "txtPart";
            cmbState.ValueMember = "ValuePart";

        }
    }
}