using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.AdminForms
{
    public partial class AddSubstanceToDrugForm : Form
    {
        private DataTable substancesDtLocal_;
        private pharmacyDataSet.substancesDataTable substancesDtSuitable_;
        private int currentDrugId_;


        public AddSubstanceToDrugForm(DataTable substancesDt, int currentDrugId)
        {
            InitializeComponent();
            substancesDtLocal_ = substancesDt;
            currentDrugId_ = currentDrugId;
            GetSuitableSubstances();
        }


        private void GetSuitableSubstances()
        {
            substancesDtSuitable_ = pharmacyDataSet1.substances;
            try
            {
                substancesTableAdapter1.FillByNotDrugId(
                substancesDtSuitable_,
                currentDrugId_);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }

            // Removing substances, which are present in local (not updated) DataTable
            List<int> excludedSubstIndices = new List<int>();
            foreach (DataRow row in substancesDtLocal_.Rows)
            {
                excludedSubstIndices.Add(row.Field<int>("subst_id"));
            }

            for (int i = 0; i < substancesDtSuitable_.Count; i++)
            {
                int index = excludedSubstIndices.FindIndex(
                    x => x == substancesDtSuitable_[i].Field<int>("subst_id"));
                if (index >= 0)
                {
                    substancesDtSuitable_.RemovesubstancesRow(substancesDtSuitable_[i]);
                    i--;
                }
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            DataRow selected = GetSelectedRow();
            if (selected == null)
            {
                return;
            }

            DataRow newRow = substancesDtLocal_.NewRow();
            newRow.ItemArray = selected.ItemArray;
            substancesDtLocal_.Rows.Add(newRow);
            Close();
        }


        private DataRow GetSelectedRow()
        {
            if (substGridView.SelectedRows.Count == 0)
            {
                return null;
            }
            return
                ((substGridView.SelectedRows[0] as DataGridViewRow)
                .DataBoundItem as DataRowView)
                .Row;
        }
    }
}
