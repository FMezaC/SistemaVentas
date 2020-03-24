using CommonSupport;
using CommonSupport.EntityLayer;
using CommonSupport.EntityDashbordLayer;
using Domain_Layer;
using Domain_Layer.DomainReports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Windows.Forms;
using PresentationLayer.ReportsLayer.ReportsViewers;

namespace PresentationLayer
{
    public partial class MenuPrincipalMDI : Form
    {
        public MenuPrincipalMDI()
        {
            InitializeComponent();
        }

        private void MenuPrincipalMDI_Load(object sender, EventArgs e)
        {
            pantallaCompleta();
            CargarDatosUser();
            MenuHeader(0,null, menuStrip1);
            DasboardView();
        }
        
        private void CargarDatosUser()
        {
            toolstepUser.Text = UserLoginCache.user;
            lblName.Text = UserLoginCache.nombre;
            lblLastName.Text = UserLoginCache.apellidos;
            lblUser.Text = UserLoginCache.tipo;
            toolStripSu.Text = UserLoginCache.Sucursal;
            miFecha.Text = DateTime.Now.ToShortDateString();
            CompanyModel model = new CompanyModel();
            List<CompanyEntity> MyList = new List<CompanyEntity>();
            MyList = model.ListCompany();
            int cont = MyList.Count;
            for (int i = 0; i < cont; i++)
            {
                toolStripStatusLabel6.Text = MyList[i]._NOMEMP;
                label1.Text = MyList[i]._NOMEMP;
            }
        }
        
        /* “Querido mantenedor: Cuando hayas terminado de intentar “optimizar” esta rutina y te hayas dado 
        cuenta de que hacerlo era un gran error, por favor, incrementa el siguiente contador como aviso al 
        siguiente mantenedor que le toque: total_horas_desperdiciadas = 16” */
        
        int lx, ly;
        int sw, sh;
        public void pantallaCompleta()
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        
        Form llamado = new Form();
        private void FormHijo(Form frmhijo, Form frmPrincipal)
        {
            bool cargado = false;
            foreach (Form llamado in frmPrincipal.MdiChildren)
            {
                if (llamado.Text == frmhijo.Text)
                {
                    cargado = true;
                    break;
                }
            }
            if (!cargado)
            {
                frmhijo.MdiParent = frmPrincipal;
                frmhijo.WindowState = FormWindowState.Maximized;
                frmhijo.Show();
                panel1.Visible = false;
            }
        }
        
        public void MenuHeader(int idMaster, ToolStripMenuItem ItemHeader, MenuStrip Menu)
        {
            MenuItemsModel Model = new MenuItemsModel();
            DataView viewsubItem = new DataView();
            viewsubItem = Model.MenuHeader(idMaster, ItemHeader, Menu);
            MenuItemsModel Privilege = new MenuItemsModel();
            List<UserPrivilegesEntity> ListPrivilege = new List<UserPrivilegesEntity>();
            ListPrivilege = Privilege.ListPrivilege(UserLoginCache.NumDocum);
            foreach (DataRowView rows in viewsubItem)
            {
                ToolStripMenuItem SubItem = new ToolStripMenuItem();
                SubItem.Text = rows["NOMSBT"].ToString();
                SubItem.Name = rows["IDSUBT"].ToString();
                SubItem.Click += new EventHandler(Eventos);
                if (ItemHeader == null)
                {
                    Menu.Items.Add(SubItem);
                }
                else
                {
                    if (ListPrivilege.Count > 0)
                    {
                        for (int i = 0; i < ListPrivilege.Count; i++)
                        {
                            if (Convert.ToInt32(rows["IDSUBT"].ToString()) == ListPrivilege[i]._IDSUBT)
                            {
                                if (ListPrivilege[i]._PERMISO != 1)
                                {
                                    SubItem.Enabled = false;
                                }
                            }
                        }
                    }
                    else
                    {
                        SubItem.Enabled = false;
                    }
                    ItemHeader.DropDownItems.Add(SubItem);
                }
                MenuHeader(int.Parse(rows["IDSUBT"].ToString()), SubItem, Menu);
            }
            
        }

        private void Eventos(object sender, EventArgs e)
        {
            ToolStripMenuItem ItemClick = (ToolStripMenuItem)sender;
            if (Convert.ToInt32(ItemClick.Name) == 3)
            {
                panel1.Visible = true;
                DasboardView();
            }
            if (Convert.ToInt32(ItemClick.Name) == 4)
            {
                this.Close();
            }
            if (Convert.ToInt32(ItemClick.Name) == 10)
            {
                AccountingSeatDesing AccDsign = new AccountingSeatDesing();
                FormHijo(AccDsign, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 11)
            {
                ChartCountDesign chardesign = new ChartCountDesign();
                FormHijo(chardesign, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 12)
            {
                EgreesDesign egress = new EgreesDesign();
                FormHijo(egress, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 13)
            {
                UtilityDesign utility = new UtilityDesign();
                FormHijo(utility, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 16)
            {
                ProductDesign prodDesign = new ProductDesign();
                FormHijo(prodDesign, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 26)
            {
                ChangePasswordDesign pass = new ChangePasswordDesign();
                pass.StartPosition = FormStartPosition.CenterScreen;
                pass.ShowDialog();
            }
            if (Convert.ToInt32(ItemClick.Name) == 17)
            {
                LineaDesign lineDsg = new LineaDesign();
                FormHijo(lineDsg,this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 18)
            {
                ClassDesign classDsg = new ClassDesign();
                FormHijo(classDsg, this);
            }
            
            if (Convert.ToInt32(ItemClick.Name) == 19)
            {
                CustumerDesign custumer = new CustumerDesign();
                FormHijo(custumer, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 21)
            {
                ProviderDesign provider = new ProviderDesign();
                FormHijo(provider, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 23)
            {
                ActivityDesing activity = new ActivityDesing();
                FormHijo(activity, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 27)
            {
                UserTypeDesign usertype = new UserTypeDesign();
                FormHijo(usertype, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 29)
            {
                DistricDesign distric = new DistricDesign();
                FormHijo(distric, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 30)
            {
                ProvinceDesign province = new ProvinceDesign();
                FormHijo(province, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 31)
            {
                PaisDesign Contry = new PaisDesign();
                FormHijo(Contry, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 33)
            {
                CivilStateDesign cilStatus = new CivilStateDesign();
                FormHijo(cilStatus, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 34)
            {
                GenderDesign gender = new GenderDesign();
                FormHijo(gender, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 35)
            {
                DocumentTypeDesign docuement = new DocumentTypeDesign();
                FormHijo(docuement, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 37)
            {
                SalesCancellationsDesign cancellations = new SalesCancellationsDesign();
                FormHijo(cancellations, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 41)
            {
                OfertsDesign oferts = new OfertsDesign();
                FormHijo(oferts, this);
            }
            
            if (Convert.ToInt32(ItemClick.Name) == 67)
            {
                BuckUps backUp = new BuckUps();
                backUp.StartPosition = FormStartPosition.CenterScreen;
                backUp.ShowDialog();
            }
            
            if (Convert.ToInt32(ItemClick.Name) == 68)
            {
                CompanyDesign company = new CompanyDesign();
                FormHijo(company, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 69)
            {
                AboutDesign about = new AboutDesign();
                about.StartPosition = FormStartPosition.CenterScreen;
                about.ShowDialog();
            }
            if (Convert.ToInt32(ItemClick.Name) == 70)
            {
                Application.Exit();
            }
            if (Convert.ToInt32(ItemClick.Name) == 22)
            {
                AreaDesign Area = new AreaDesign();
                FormHijo(Area, this);
            }
            //if (Convert.ToInt32(ItemClick.Name) == 57)
            //{
            //    CreditNoteDeign credit = new CreditNoteDeign();
            //    FormHijo(credit, this);
            //}
            //if (Convert.ToInt32(ItemClick.Name) == 56)
            //{
            //    DebitNoteDesign debit = new DebitNoteDesign();
            //    FormHijo(debit, this);
            //}
            if (Convert.ToInt32(ItemClick.Name) == 77)
            {
                MesuareDesign mesuare = new MesuareDesign();
                FormHijo(mesuare, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 25)
            {
                UserPrivilegesDesign design = new UserPrivilegesDesign();
                FormHijo(design, this);
            }

            // bonificacion
            if (Convert.ToInt32(ItemClick.Name) == 72)
            {
                BonusDesign Bonusdesign = new BonusDesign();
                FormHijo(Bonusdesign, this);
            }
            
            // Creacion modulo de ventas
            if (Convert.ToInt32(ItemClick.Name) == 54)
            {
                if (ValidaCaja())
                {
                    SalesDesign sales = new SalesDesign();
                    FormHijo(sales, this);
                }
                else
                    MessageBox.Show("!Usted no Dispone de Apertura de Caja¡", "CASH CLOSING");
            }
            //if (Convert.ToInt32(ItemClick.Name) == 55)
            //{
            //    if (ValidaCaja())
            //    {
            //        BillingDesign billing = new BillingDesign();
            //        FormHijo(billing, this);
            //    }
            //    else
            //        MessageBox.Show("!Usted no Dispone de Apertura de Caja¡", "CASH CLOSING");
            //}

            // Caja
            if (Convert.ToInt32(ItemClick.Name) == 75)
            {
                if (!ValidaCaja())
                {
                    CashOpeningDesign design = new CashOpeningDesign();
                    design.StartPosition = FormStartPosition.CenterScreen;
                    design.ShowDialog();
                }
                else
                    MessageBox.Show("!Usted Ya Cuenta con una Caja Aperturada¡","CASH OPENING");
            }
            if (Convert.ToInt32(ItemClick.Name) == 76)
            {
                if (ValidaCaja())
                {
                    CashClosingDesign Close = new CashClosingDesign();
                    Close.StartPosition = FormStartPosition.CenterScreen;
                    Close.ShowDialog();
                }
                else
                    MessageBox.Show("!Usted no Dispone de Apertura de Caja¡", "CASH CLOSING");
            }

            // Modulo Almacen
            if (Convert.ToInt32(ItemClick.Name) == 8)
            {
                InventoryDesign Invent = new InventoryDesign();
                FormHijo(Invent, this);
            }
            if (Convert.ToInt32(ItemClick.Name) == 59)
            {
                PurchasingDesing charsing = new PurchasingDesing();
                FormHijo(charsing, this);
            }

            //Modulo de reportes
            if (Convert.ToInt32(ItemClick.Name) == 63)
            {
                SalesReport report = new SalesReport();
                FormHijo(report, this);
            }

            if (Convert.ToInt32(ItemClick.Name) == 62)
            {
                ProductsReport report = new ProductsReport();
                FormHijo(report, this);
            }

            // Recursos Humanos
            if (Convert.ToInt32(ItemClick.Name) == 45)
            {
                EmployeePaymentsDesign report = new EmployeePaymentsDesign();
                FormHijo(report, this);
            }

            if (Convert.ToInt32(ItemClick.Name) == 47)
            {
                EmployeesDesign employee = new EmployeesDesign();
                FormHijo(employee, this);
            }
        }

        private bool ValidaCaja()
        {
            CashModel model = new CashModel();
            if (model.ValidateCashModel())
                return true;
            else
                return false;
        }

        private void DasboardView()
        {
            DashboardDomain Model = new DashboardDomain();
            DashboardEntity Entity = new DashboardEntity();
            Model.DashboardModel(Entity);

            chart1.Series[0].Points.DataBindXY(Entity.DayName, Entity.SalesAmount);
            chart2.Series[0].Points.DataBindXY(Entity.WeeksName, Entity.SalesByWeeks);

            Model.CountRegisterBDModel(Entity);
            lblCustumer.Text = Entity._CUSTOMER;
            lblProducts.Text = Entity._PRODUCTS;
            lblBillign.Text = Entity._BILLIGN;
            lblSeat.Text = Entity._SEAT;
        }
    }
}
