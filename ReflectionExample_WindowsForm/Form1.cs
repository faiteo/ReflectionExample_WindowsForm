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


namespace ReflectionExample_WindowsForm
     
{
    public partial class Form1 : Form
    {

        //ReflectionExample_WindowsForm.Model.Member mem = new ReflectionExample_WindowsForm.Model.Member();
        //Type t1 = mem.GetType();
        //Type t2 = typeof(ReflectionExample_WindowsForm.Model.Member);

       
        
        
        
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Type T;
            if (txtInput.Text != "")
            {
                T = Type.GetType(txtInput.Text); 

           // Type T = Type.GetType(txtInput.Text); 


            lstBoxProperties.Items.Clear();
            lstBoxConstructors.Items.Clear();
            lstBoxInterfaces.Items.Clear();
            lstBoxMethods.Items.Clear();
            txtInput.Text = "";

            lblTypeName.Text = T.Name + " " + "Class";

            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo item in constructors)
            {
                lstBoxConstructors.Items.Add(item.ToString());

            }

            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo item in properties)
            {
                lstBoxProperties.Items.Add(item.Name);

            }


            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo item in methods)
            {
                lstBoxMethods.Items.Add(item.Name);

            }



            Type[] interfaces = T.GetInterfaces();
            foreach (Type item in interfaces)
            {
                lstBoxInterfaces.Items.Add(item.Name);

            }
           }
            else
            {
                MessageBox.Show("Please Enter a valid Type Name Ex.: \"Namespace.Classname\"");
            }

            }
        }









    }

