using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace _9lab
{
    public partial class Request : Form
    {
        static string sConnectionStr = "Server=localhost; Port=5432; User Id=postgres; Password=yarmashka; Database=normal";
        public static NpgsqlConnection sConnection = new NpgsqlConnection(sConnectionStr);

        public Request()
        {
            InitializeComponent();
            sConnection.Open();
            using (var sCommand = new NpgsqlCommand())
            {
                sCommand.Connection = sConnection;
                sCommand.CommandText = "select * from information_schema.columns where table_schema = 'public' and table_name <> 'reltable'";
                using (NpgsqlDataReader reader = sCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new ListViewItem(new string[] { (string)reader["column_name"], (string)reader["table_name"], (string)reader["data_type"] });
                        AllFields.Items.Add(item);
                        NameBox.Items.Add((string)reader["column_name"]);
                    }
                }
            }
        }

        private void EnabledButtons()
        {
            if (SelectedFields.Items.Count > 0)
            {
                Run.Enabled = true;
                Check.Enabled = true;
            }
            else
            {
                Run.Enabled = false;
                Check.Enabled = false;
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in AllFields.SelectedItems)
            {
                if (SelectedFields.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == itemRow.Text && x.SubItems[1].Text == itemRow.SubItems[1].Text) == null)
                {
                    SelectedFields.Items.Add((ListViewItem)itemRow.Clone());
                    SortAllFields.Items.Add((ListViewItem)itemRow.Clone());
                }
            }
            EnabledButtons();
        }

        private void DoubleRight_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in AllFields.Items)
            {
                if (SelectedFields.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == itemRow.Text && x.SubItems[1].Text == itemRow.SubItems[1].Text) == null)
                {
                    SelectedFields.Items.Add((ListViewItem)itemRow.Clone());
                    SortAllFields.Items.Add((ListViewItem)itemRow.Clone());
                }
            }
            EnabledButtons();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in SelectedFields.SelectedItems)
            {
                SortAllFields.Items.Remove(SortAllFields.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == itemRow.Text && x.SubItems[1].Text == itemRow.SubItems[1].Text));
                itemRow.Remove();
            }
            EnabledButtons();
        }

        private void DoubleLeft_Click(object sender, EventArgs e)
        {
            SelectedFields.Items.Clear();
            SortAllFields.Items.Clear();
            EnabledButtons();
        }

        private void NameBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueBox.Items.Clear();
            CriterionBox.Items.Clear();
            ListViewItem Item = AllFields.Items[NameBox.SelectedIndex];
            using (var sCommand = new NpgsqlCommand())
            {
                sCommand.Connection = sConnection;
                sCommand.CommandText = "SELECT DISTINCT \"" + Item.SubItems[0].Text + "\" FROM \"" + Item.SubItems[1].Text + "\"";
                using (NpgsqlDataReader reader = sCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ValueBox.Items.Add(reader[0]);
                    }
                }
            }

            switch (Item.SubItems[2].Text)
            {
                case "text":
                    {
                        CriterionBox.Items.AddRange(new[] { "=", "<>" });
                        break;
                    }
                default:
                    {
                        CriterionBox.Items.AddRange(new[] { "=", "<>", ">", "<", ">=", "<=" });
                        break;
                    }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if ((NameBox.SelectedIndex != -1) && (CriterionBox.SelectedIndex != -1) && (ValueBox.SelectedIndex != -1) && (JoinBox.SelectedIndex != -1))
            {
                string value;
                if (AllFields.Items[NameBox.SelectedIndex].SubItems[2].Text != "integer")
                    value = "'" + ValueBox.SelectedItem.ToString() + "'";
                else
                    value = ValueBox.SelectedItem.ToString();
                var item = new ListViewItem(new string[] { NameBox.SelectedItem.ToString(), AllFields.Items[NameBox.SelectedIndex].SubItems[1].Text, CriterionBox.SelectedItem.ToString(), value, JoinBox.SelectedItem.ToString() });
                ConditionsList.Items.Add(item);
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in ConditionsList.SelectedItems)
            {
                itemRow.Remove();
            }
        }

        private void Right1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in SortAllFields.SelectedItems)
            {
                if (SortSelectedFields.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == itemRow.Text && x.SubItems[1].Text == itemRow.SubItems[1].Text) == null)
                {
                    SortSelectedFields.Items.Add((ListViewItem)itemRow.Clone());
                    if (ASC.Checked)
                        SortSelectedFields.Items[SortSelectedFields.Items.Count - 1].Tag = " ASC";
                    else
                        SortSelectedFields.Items[SortSelectedFields.Items.Count - 1].Tag = " DESC";
                }
            }
        }

        private void Left1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in SortSelectedFields.SelectedItems)
            {
                itemRow.Remove();
            }
        }

        private void DoubleRight1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem itemRow in SortAllFields.Items)
            {
                if (SortSelectedFields.Items.Cast<ListViewItem>().FirstOrDefault(x => x.Text == itemRow.Text && x.SubItems[1].Text == itemRow.SubItems[1].Text) == null)
                {
                    SortSelectedFields.Items.Add((ListViewItem)itemRow.Clone());
                    if (ASC.Checked)
                        SortSelectedFields.Items[SortSelectedFields.Items.Count - 1].Tag = " ASC";
                    else
                        SortSelectedFields.Items[SortSelectedFields.Items.Count - 1].Tag = " DESC";
                }
            }
        }

        private void DoubleLeft1_Click(object sender, EventArgs e)
        {
            SortSelectedFields.Items.Clear();
        }

        private void SortSelectedFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SortSelectedFields.SelectedItems.Count > 0)
            {
                if (SortSelectedFields.SelectedItems[0].Tag.ToString() == " ASC")
                    ASC.Checked = true;
                else
                    DESC.Checked = true;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SortSelectedFields.SelectedItems.Count > 0)
            {
                if (ASC.Checked == true)
                    SortSelectedFields.SelectedItems[0].Tag = " ASC";
                else
                    SortSelectedFields.SelectedItems[0].Tag = " DESC";
            }
        }

        public void searchRelations(string table1, string table2, ref string FROM, ref string WHERE)
        {
            using (var sCommand = new NpgsqlCommand())
            {
                sCommand.Connection = sConnection;
                sCommand.CommandText = "select relations, via from reltable where (table1 = @table1 and table2 = @table2) or (table1 = @table2 and table2 = @table1)";
                sCommand.Parameters.AddWithValue("@table1", table1);
                sCommand.Parameters.AddWithValue("@table2", table2);
                NpgsqlDataReader reader = sCommand.ExecuteReader();
                while (reader.Read())
                {
                    var relations = reader["relations"].ToString();
                    var via = reader["via"].ToString();
                    if (FROM.IndexOf(via) == -1)
                    {
                        FROM += ", " + "\"" + via + "\"";
                    }
                    if (relations != "")
                    {
                        if (WHERE.IndexOf(relations) == -1)
                        {
                            WHERE += relations + " AND ";
                        }
                    }
                    else
                    {
                        reader.Close();
                        searchRelations(table1, via, ref FROM, ref WHERE);
                        searchRelations(table2, via, ref FROM, ref WHERE);
                    }
                }
                reader.Close();
            }
        }

        private string SQL()
        {
            List<string> tables = new List<string>();
            string SELECT = "SELECT ";
            string ORDER = " ORDER BY ";
            string FROM = " FROM ";
            string WHERE = " WHERE ";

            for (int i = 0; i < SelectedFields.Items.Count; i++)
            {
                SELECT += "\"" + SelectedFields.Items[i].SubItems[1].Text + "\"" + "." + "\"" + SelectedFields.Items[i].SubItems[0].Text + "\", ";
                if (FROM.IndexOf(SelectedFields.Items[i].SubItems[1].Text) == -1)
                {
                    FROM += "\"" + SelectedFields.Items[i].SubItems[1].Text + "\", ";
                    tables.Add(SelectedFields.Items[i].SubItems[1].Text);
                }
            }
            SELECT = SELECT.Remove(SELECT.LastIndexOf(","));
            FROM = FROM.Remove(FROM.LastIndexOf(","));

            if (tables.Count != 1)
            {
                for (int i = 0; i < tables.Count; i++)
                {
                    for (int j = i + 1; j < tables.Count; j++)
                    {
                        searchRelations(tables[i], tables[j], ref FROM, ref WHERE);
                    }
                }
				WHERE = WHERE.Remove(WHERE.LastIndexOf(" AND"));
			}

            SELECT += FROM;

            if (ConditionsList.Items.Count > 0)
            {
                if (WHERE != " where")
                    WHERE += " and";
                WHERE += " (";
                for (int i = 0; i < ConditionsList.Items.Count; i++)
                {
                    try
                    {
                        WHERE += "\"" + ConditionsList.Items[i].SubItems[1].Text + "\"" + "." + "\"" + ConditionsList.Items[i].SubItems[0].Text + "\"" + " " + ConditionsList.Items[i].SubItems[2].Text + " " + ConditionsList.Items[i].SubItems[3].Text + " " + ConditionsList.Items[i].SubItems[4].Text + " ";
                    }
                    catch
                    {
                        MessageBox.Show("Поле одного из условий не принадлежит выбранным таблицам. Данное условие будет проигнорировано.");
                    }
                }
                if (WHERE.LastIndexOf("AND") > WHERE.LastIndexOf("OR"))
                    WHERE = WHERE.Remove(WHERE.LastIndexOf(" AND"));
                else
                    WHERE = WHERE.Remove(WHERE.LastIndexOf(" OR"));
                WHERE += ")";
            }

            if (WHERE != " WHERE ")
                SELECT += WHERE;

            if (SortSelectedFields.Items.Count > 0)
            {
                for (int i = 0; i < SortSelectedFields.Items.Count; i++)
                {
                    ORDER += "\"" + SortSelectedFields.Items[i].SubItems[1].Text + "\"" + "." + "\"" + SortSelectedFields.Items[i].SubItems[0].Text + "\"" + SortSelectedFields.Items[i].Tag + ", ";
                }
                ORDER = ORDER.Remove(ORDER.LastIndexOf(","));
                SELECT += ORDER;
            }
            return SELECT;
        }

        private void Check_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SQL());
        }

        private void Run_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            var requestAdapter = new NpgsqlDataAdapter(SQL(), sConnection);
            requestAdapter.Fill(ds, "request");
            dataGridView1.DataSource = ds.Tables["request"];
        }
    }
}