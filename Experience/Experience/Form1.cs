using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
public class MainForm : Form
{
    public MainForm() { InitializeComponent(); SetUp(); }
    private DataGridView dgView;
    private DataSet dataSet = new DataSet("dataSet");
    #region WindowsFormDesign
    private Container components;
    protected override void Dispose(bool disposing) { if (disposing) if (components != null) components.Dispose(); base.Dispose(disposing); }
    private void InitializeComponent()
    {
        this.dgView = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
        this.SuspendLayout();
        // 
        // dgView
        // 
        this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgView.Location = new System.Drawing.Point(3, 7);
        this.dgView.Name = "dgView";
        this.dgView.Size = new System.Drawing.Size(241, 161);
        this.dgView.TabIndex = 3;
        // 
        // MainForm
        // 
        this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
        this.ClientSize = new System.Drawing.Size(248, 171);
        this.Controls.Add(this.dgView);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
        this.Text = "DataGridView";
        this.TopMost = true;
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
        this.ResumeLayout(false);

    }
    #endregion
    public static void Main() { Application.Run(new MainForm()); }
    private void Form1_Load(object o, EventArgs e) { }
    private void SetUp() { CreDataSet(); dgView.DataSource = dataSet; dgView.DataMember = "Block"; dgView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells; }
    // Создание DataSet
    private void CreDataSet()
    {
        DataTable dataTable = new DataTable("Block");
        dataSet.Tables.Add(dataTable);
        DataColumn cNpp = new DataColumn("Nnnnnn", typeof(int)); dataTable.Columns.Add(cNpp);
        DataColumn cX = new DataColumn("X", typeof(decimal)); dataTable.Columns.Add(cX);
        DataColumn cY = new DataColumn("Y", typeof(decimal)); dataTable.Columns.Add(cY);
        DataRow r;
        for (int i = 0; i < 10000; i++)
        {
            r = dataTable.NewRow(); dataTable.Rows.Add(r);
            r["Nnnnnn"] = i; dataTable.Rows[i]["X"] = 10 * i; dataTable.Rows[i]["Y"] = 100000 * i;
        }
    }
}