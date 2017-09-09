using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Reflection_Demo
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

        private void btnDiscoverTypeInfo_Click(object sender, EventArgs e)
        {
            string TypeName = txtTypeName.Text;
            Type T = Type.GetType(TypeName);
            lstMethods.Items.Clear();
            lstProperties.Items.Clear();
            lstConstructors.Items.Clear();

            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo MI in methods)
            {
                lstMethods.Items.Add(MI.ReturnType.Name + " " + MI.Name);
            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo PI in properties)
            {
                lstProperties.Items.Add(PI.PropertyType.Name + " " + PI.Name);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo CI in constructors)
            {
                lstConstructors.Items.Add(CI.ToString());
            }
        }
    }
}
