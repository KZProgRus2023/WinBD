using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinBD.Основные_фондыDataSet1TableAdapters;

namespace WinBD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
DataView Основные_средстваDataView;
        private void button1_Click(object sender, EventArgs e)
        {
            // Загрузка таблицы данными
            Основные_средстваTableAdapter.Fill(основные_фондыDataSet.Основные_средства);
            // Настройка объекта DataView
            Основные_средстваDataView = new
                DataView(основные_фондыDataSet.Основные_средства);
            // Настройка dataGridView для отобрадения данных
            dataGridView1.DataSource = Основные_средстваDataView;
            // Присвоение исходного прядка сортировки
            Основные_средстваDataView.Sort = "Фамилия";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oleDbDataAdapter1.Update(основные_фондыDataSet);
        }
    }
}
