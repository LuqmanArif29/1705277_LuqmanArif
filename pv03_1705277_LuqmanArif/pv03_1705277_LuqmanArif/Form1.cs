using pv03_1705277_LuqmanArif.Model;
using pv03_1705277_LuqmanArif.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_1705277_LuqmanArif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodoRepository todo = new TodoRepository();

           

            string nim = tbNim.Text;
            btnAdd.Enabled = true;
     
           
         

            if(todo.getByWhat(nim) == 1)
            {
                dataGridView2.DataSource = todo.getByNim(nim);
                tbNim.Enabled = false;
                submitNim.Enabled = false;
            }
            else
            {
                MessageBox.Show("Data Tidak Ada!!!","Warning");
                tbNim.Enabled = true;
                submitNim.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.NimMhs = tbNim.Text;
            temp.Nama = tbNama.Text;
            temp.Kategori = tbKategori.Text;
         

            TodoRepository todo = new TodoRepository();

            todo.addTodo(temp);

            string nim = tbNim.Text;

            dataGridView2.DataSource = todo.getByNim(nim);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(tbDelete.Text);
        
            TodoRepository todo = new TodoRepository();

            todo.deleteTodo(temp);
            btnDelete.Enabled = false;
            string nim = tbNim.Text;

            dataGridView2.DataSource = todo.getByNim(nim);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(tbId.Text);
            temp.Nama = tbNama1.Text;
            temp.Kategori = tbKegiatan2.Text;
            btnUpdate.Enabled = false;
            tbId.Enabled = false;
            TodoRepository todo = new TodoRepository();

            todo.updateTodo(temp);

            string nim = tbNim.Text;

            dataGridView2.DataSource = todo.getByNim(nim);
        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
