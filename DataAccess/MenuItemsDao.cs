using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using CommonSupport.EntityLayer;

namespace DataAccess
{
    public class MenuItemsDao : ConnectionToSql
    {
        public DataView MenuHeader(int idMaster, ToolStripMenuItem ItemHeader, MenuStrip Menu)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                DataTable table = new DataTable();
                string cade = @"SELECT ISNULL(IDSUBT,'')IDSUBT,ISNULL(IDMENU,'')IDMENU,
                ISNULL(NOMSBT,'')NOMSBT FROM MENU_SUBITEM";
                SqlDataAdapter da = new SqlDataAdapter(cade, conect);
                da.Fill(table);
                DataView viewsubItem = new DataView(table);
                viewsubItem.RowFilter = table.Columns["IDMENU"].ColumnName + "=" + idMaster;
                return viewsubItem;
            }
        }
        
        public List<UserPrivilegesEntity> ListPrivileges(string DNI)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT IDSUBT, NOMSBT, USERDNI, PERMISO FROM MENU_SUBITEM MN
                INNER JOIN PERMISOS_USER PR ON MN.IDSUBT = PR.CODITM WHERE PR.USERDNI = @DNI";
                cmd.Parameters.AddWithValue("@DNI", DNI);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserPrivilegesEntity> MyList = new List<UserPrivilegesEntity>();
                while (reader.Read())
                {
                    MyList.Add(new UserPrivilegesEntity() {
                        _IDSUBT = reader.GetInt32(0),
                        _NOMSBT = reader.GetString(1),
                        _USERDNI = reader.GetString(2),
                        _PERMISO = reader.GetInt32(3)
                    });
                }
                return MyList;
            }
        }

        public List<UserPrivilegesEntity> Privileges()
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT ISNULL(IDSUBT,'')IDSUBT, ISNULL(UPPER(NOMSBT),'')NOMSBT,
                ISNULL(IDMENU,'')IDMENU FROM MENU_SUBITEM ORDER BY ORDEN ASC";
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserPrivilegesEntity> MyList = new List<UserPrivilegesEntity>();
                while (reader.Read())
                {
                    MyList.Add(new UserPrivilegesEntity()
                    {
                        _IDSUBT = reader.GetInt32(0),
                        _NOMSBT = reader.GetString(1),
                        _USERDNI = Convert.ToString(reader.GetInt32(2))
                    });
                }
                return MyList;
            }
        }

        public List<MenuItemsEntity> ListUserPrivileges(string UserName)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT MN.IDSUBT, UPPER(MN.NOMSBT)NOMSBT, US.NUMDNI, EM.NOMEMP+' '+EM.APEPAT+' '+EM.APEMAT AS EMPLEADO,
                TUS.TIPOUS, US.ESTADO,  PR.PERMISO, US.USUARI FROM MENU_SUBITEM MN INNER JOIN PERMISOS_USER PR ON MN.IDSUBT = PR.CODITM 
                INNER JOIN EMPLEADOS EM ON EM.NUMDOC = PR.USERDNI INNER JOIN USUARIOS US ON EM.NUMDOC = US.NUMDNI
                INNER JOIN TIP_USUARIO TUS ON TUS.ID = US.IDTIPO WHERE ESTADO = 'ACTIVO' AND NOMEMP LIKE '%'+@NAME+'%'";
                cmd.Parameters.AddWithValue("@NAME", UserName);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<MenuItemsEntity> MyList = new List<MenuItemsEntity>();
                while (reader.Read())
                {
                    MyList.Add(new MenuItemsEntity()
                    {
                        _IDSUBT = reader.GetInt32(0),
                        _NOMSBT = reader.GetString(1),
                        _NUMDOC = reader.GetString(2),
                        _EMPLEA = reader.GetString(3),
                        _TIPUSU = reader.GetString(4),
                        _ESTADO = reader.GetString(5),
                        _PRIVILEG = reader.GetInt32(6),
                        _USUARI = reader.GetString(7)
                    });
                }
                return MyList;
            }
        }

        public List<UserPrivilegesEntity> FilterUpdate(string NumDoc)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"SELECT PR.ID, MN.IDSUBT, UPPER(MN.NOMSBT)NOMSBT, PR.PERMISO,ISNULL(SB.IDMENU,'')IDMENU
				FROM MENU_SUBITEM MN INNER JOIN PERMISOS_USER PR ON MN.IDSUBT = PR.CODITM 
				INNER JOIN MENU_SUBITEM SB ON SB.IDSUBT = PR.CODITM WHERE PR.USERDNI = @DOCUMENT ORDER BY MN.ORDEN ASC";
                cmd.Parameters.AddWithValue("@DOCUMENT", NumDoc);
                cmd.CommandType = CommandType.Text;
                SqlDataReader reader = cmd.ExecuteReader();
                List<UserPrivilegesEntity> MyList = new List<UserPrivilegesEntity>();
                while (reader.Read())
                {
                    MyList.Add(new UserPrivilegesEntity()
                    {
                        _ID = reader.GetInt32(0),
                        _IDSUBT = reader.GetInt32(1),
                        _NOMSBT = reader.GetString(2),
                        _PERMISO = reader.GetInt32(3),
                        _USERDNI = Convert.ToString(reader.GetInt32(4))
                    });
                }
                return MyList;
            }
        }

        public void InsertPrivileges(UserPrivilegesEntity Insert)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"INSERT INTO PERMISOS_USER(CODITM, USERDNI, PERMISO, USU_ASG)
                VALUES(@CODITM, @USERDNI, @PERMISO, @USU_ASG)";
                cmd.Parameters.AddWithValue("@CODITM", Insert._IDSUBT);
                cmd.Parameters.AddWithValue("@USERDNI", Insert._USERDNI);
                cmd.Parameters.AddWithValue("@PERMISO", Insert._PERMISO);
                cmd.Parameters.AddWithValue("@USU_ASG", Insert._NOMSBT);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePrivileges(UserPrivilegesEntity Update)
        {
            using (var conect = GetConnection())
            {
                conect.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conect;
                cmd.CommandText = @"UPDATE PERMISOS_USER
                SET USU_ASG = @USU_ASG, PERMISO = @PERMISO WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", Update._IDSUBT);
                cmd.Parameters.AddWithValue("@PERMISO", Update._PERMISO);
                cmd.Parameters.AddWithValue("@USU_ASG", Update._NOMSBT);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
