using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonSupport.EntityLayer;
using CommonSupport;
using Domain_Layer;

namespace PresentationLayer
{
    public partial class OfertsNewUpdateDesign : Form
    {
        public OfertsNewUpdateDesign()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OfertsNewUpdateDesign_Load(object sender, EventArgs e)
        {
            
        }

        public void estado()
        {
            StateGeneralModel model = new StateGeneralModel();
            comboBox1.DataSource = model.ListState();
            comboBox1.DisplayMember = "_ESTADO";
            comboBox1.ValueMember = "_ESTADO";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SearchDesign design = new SearchDesign();
            design.search = "Productos";
            design.ListDataSearch();
            design.StartPosition = FormStartPosition.CenterScreen;
            design.ShowDialog();
            textBox1.Text = design.CODPROD;
            label2.Text = design.PRODUC;
        }
        
        public void NewOfertInsert()
        {
            int NewID;
            OfertsEntity Entity = new OfertsEntity();
            OfertsModel model = new OfertsModel();
            if (btnNew.Text != "Grabar")
            {
                NewID = Convert.ToInt32(model.NewID());
                Entity._ID = NewID;
                Entity._DESCUENTO = Convert.ToDecimal(textBox3.Text);
                Entity._TIPODESCT = textBox2.Text;
                Entity._FECHIICIO = dateTimePicker1.Value;
                Entity._FECHFINAL = dateTimePicker2.Value;
                Entity._ESTADO = comboBox1.Text;
                Entity._USUARIO = UserLoginCache.user;
                model.InsertNewOfert(Entity);

                foreach (DataGridViewRow rows in dataGridView1.Rows)
                {
                    OfertsDetailEntity entity2 = new OfertsDetailEntity();
                    entity2._IDDESC = NewID;
                    entity2._CODPRO = rows.Cells["codprod"].Value.ToString();
                    entity2._CANPRO = Convert.ToInt32(rows.Cells["cant"].Value);
                    entity2._PREUNT = Convert.ToDecimal(rows.Cells["PreUnit"].Value);
                    OfertsDetailModel model2 = new OfertsDetailModel();
                    model2.NewDatilOfert(entity2);
                }
                
            }
            else
            {
                Entity._ID = ID_OFT;
                Entity._DESCUENTO = Convert.ToDecimal(textBox3.Text);
                Entity._TIPODESCT = textBox2.Text;
                Entity._FECHIICIO = dateTimePicker1.Value;
                Entity._FECHFINAL = dateTimePicker2.Value;
                Entity._ESTADO = comboBox1.Text;
                Entity._USUARIO = UserLoginCache.user;
                model.UpdateOfert(Entity);
            }
        }

        public int ID_OFT;
        public void CargarGrilla()
        {
            OfertsDetailModel model = new OfertsDetailModel();
            dataGridView1.DataSource = model.ListOfert(ID_OFT);
            dataGridView1.ReadOnly = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (validaTextbox())
            {
                NewOfertInsert();
                FlaatSlanshDesign design = new FlaatSlanshDesign();
                design.StartPosition = FormStartPosition.CenterScreen;
                design.title = "Generando Ofertas";
                design.ShowDialog();
                this.Close();
            }
        }

        bool validaTextbox()
        {
            if (textBox2.Text == string.Empty)
            {
                errorProvider1.SetError(textBox2,"Ingrese Tipo descuento.");
            }
            else
            {
                errorProvider1.SetError(textBox2, null);
                if (textBox3.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox3, "Ingrese el porcentaje de descuento.");
                }
                else
                {
                    errorProvider1.SetError(textBox3, null);
                    if (dataGridView1.RowCount > 0)
                    {
                        errorProvider1.SetError(textBox1, null);
                        return true;
                    }
                    else
                        errorProvider1.SetError(textBox1, "Agrege producto a aplicar descuento.");
                }
            }
            return false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                    {
                        if (textBox1.Text != string.Empty)
                        {
                            ProductModel model = new ProductModel();
                            List<ProductEntity> MyList = new List<ProductEntity>();
                            MyList = model.FilterProdct(Convert.ToDouble(textBox1.Text));

                            bool ban = false;
                            for (int i = 0; i < MyList.Count; i++)
                            {
                                double cantProd = MyList[i]._CANTPRO - MyList[i]._CANTRES;
                                if (cantProd > 0)
                                {
                                    if (dataGridView1.RowCount == 0)
                                    {
                                        dataGridView1.Rows.Add(MyList[i]._CODPROD, MyList[i]._DESCPRO,
                                                cantProd, MyList[i]._PREUNIT);
                                        label2.Text = "";
                                        textBox1.Clear();
                                        textBox1.Focus();
                                    }
                                    else
                                    {
                                        foreach (DataGridViewRow rows in dataGridView1.Rows)
                                        {
                                            if (MyList[i]._CODPROD == Convert.ToDouble(rows.Cells["codprod"].Value))
                                            {
                                                label2.Text = "¡PRODUCTO YA FUE AGREGADO!";
                                                ban = true;
                                                break;
                                            }
                                        }

                                        if (!ban && RemoveBD != "BD")
                                        {
                                            label2.Text = "";
                                            dataGridView1.Rows.Add(MyList[i]._CODPROD, MyList[i]._DESCPRO,
                                            cantProd, MyList[i]._PREUNIT);
                                            textBox1.Clear();
                                            textBox1.Focus();
                                        }
                                    else if (!ban && RemoveBD == "BD")
                                    {
                                        for (int r = 0; r < MyList.Count; r++)
                                        {
                                            OfertsDetailEntity entity3 = new OfertsDetailEntity();
                                            entity3._IDDESC = ID_OFT;
                                            entity3._CODPRO = Convert.ToString(MyList[r]._CODPROD);
                                            entity3._CANPRO = Convert.ToInt32(cantProd);
                                            entity3._PREUNT = Convert.ToDecimal(MyList[r]._PREUNIT);
                                            OfertsDetailModel model3 = new OfertsDetailModel();
                                            model3.NewDatilOfert(entity3);
                                            CargarGrilla();
                                        }
                                    }
                                   }
                                }
                                else
                                    label2.Text = "¡PRODUCTO SIN STOCK!";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        public string RemoveBD="AD";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar" && RemoveBD != "BD")
                {
                    if (dataGridView1.RowCount > 0)
                        dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar" && RemoveBD == "BD")
                {
                    DialogResult result = MessageBox.Show("¿Desea Eliminar el producto de la oferta?","", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        OfertsDetailModel model = new OfertsDetailModel();
                        model.DeleteDetailOfert(Convert.ToInt32(dataGridView1.CurrentRow.Cells["_IDDESC"].Value));
                        CargarGrilla();
                    }
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("No se puede eliminar Oferta!.");   
            }
        }
    }
}
