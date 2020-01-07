using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSqlLiteWinForm
{
    public partial class Form1 : Form
    {
        private const decimal NUMERIC_INCREMENT = 0.001M;
        private const byte DECIMAL_PLACE = 4;
        private const string SQL_NAME = "Test.sqlite";
        private const string SQL_CONNECTION = "Data Source=Test.sqlite";

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Increment = NUMERIC_INCREMENT;
            numericUpDown1.DecimalPlaces = DECIMAL_PLACE;
            numericUpDown2.Increment = NUMERIC_INCREMENT;
            numericUpDown2.DecimalPlaces = DECIMAL_PLACE;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Math.Round(numericUpDown1.Value / numericUpDown2.Value, 4);

            resultLbl.Text = result.ToString();

            SQLiteConnection connection = new SQLiteConnection(SQL_CONNECTION);
            connection.Open();
            var one = Convert.ToDecimal(numericUpDown1.Value, new CultureInfo("en-US"));
            var two = Convert.ToDecimal(numericUpDown2.Value, new CultureInfo("en-US"));
            var three = Convert.ToDecimal(result, new CultureInfo("en-US"));

            string sql = "insert into counter (name, oneInput, twoInput, output)" +
                         " values ('my name', @one," +
                         " @two," +
                         " @three)";

            SQLiteCommand command = new SQLiteCommand(sql, connection);
            command.Parameters.AddWithValue("@one", one);
            command.Parameters.AddWithValue("@two", two);
            command.Parameters.AddWithValue("@three", three);

            command.ExecuteNonQuery();

            connection.Clone();
        }

        private void showHistory_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();

            using (var connection = new SQLiteConnection(SQL_CONNECTION))
            {
                connection.Open();

                string sql = "SELECT * FROM counter";

                var command = new SQLiteCommand(sql, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    builder.Append($"name: {reader.GetString(0)}, " +
                                   $"oneInput: {reader.GetDecimal(1)}, " +
                                   $"twoInput: {reader.GetDecimal(2)}, " +
                                   $"result: {reader.GetDecimal(3)}");
                    builder.AppendLine();
                }
            }

            richTextBox1.Text = builder.ToString();
        }

        private void inGridBtn_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder();

            using (var connection = new SQLiteConnection(SQL_CONNECTION))
            {
                connection.Open();

                string sql = "SELECT * FROM counter";

                var command = new SQLiteCommand(sql, connection);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows
                        .Add(reader.GetString(0), reader.GetDecimal(1), reader.GetDecimal(2), reader.GetDecimal(3));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(SQL_NAME))
            {
                SQLiteConnection.CreateFile(SQL_NAME);

                SQLiteConnection connection = new SQLiteConnection(SQL_CONNECTION);

                connection.Open();
                string sql = "create table counter (name varchar(20), oneInput decimal, twoInput decimal, output decimal)";

                SQLiteCommand command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();

                connection.Clone();
            }

            //numericUpDown1.ValueChanged += NumericUpDownValueChanged;
            numericUpDown2.ValueChanged += NumericUpDownValueChanged;
        }

        private void NumericUpDownValueChanged(object sender, EventArgs e)
        {
            NumericUpDown element = (NumericUpDown) sender;

            if (element.Value == 0)
            {
                button1.Enabled = false;
                errorLabel.Visible = true;
            }
            else
            {
                button1.Enabled = true;
                errorLabel.Visible = false;
            }
        }
    }
}
