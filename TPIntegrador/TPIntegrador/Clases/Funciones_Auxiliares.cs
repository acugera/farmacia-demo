using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//
using System.Windows.Forms;
using System.Data;
//
namespace TPIntegrador
{
    class Funciones_Auxiliares
    {
        public void cargar_combo(ComboBox combo, string nombre_tabla, BDHelper oDatos)
        {
            DataTable tabla = oDatos.consultarTabla(nombre_tabla);
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName.ToString();
        }
        public void cargar_lista(ListBox list, string nombre_tabla, BDHelper oDatos)
        {
            DataTable tabla = oDatos.consultarTabla(nombre_tabla);
            list.DataSource = tabla;
            list.DisplayMember = tabla.Columns[1].ColumnName;
            list.ValueMember = tabla.Columns[0].ColumnName.ToString();
        }
        public bool numberVal(Char c)
        {
            if ((c >= '0' && c <= '9') || Convert.ToInt32(c) == 8)
            {
                return true;
            }
            return false;
        }

        public bool cuit(Char c)
        {
            if ((c >= '0' && c <= '9') || Convert.ToInt32(c) == 8 || Convert.ToInt32(c) == 45)
            {
                return true;
            }
            return false;
        }
    }
}
