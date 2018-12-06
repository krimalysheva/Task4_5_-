using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssemblyLibr;
using Books.BL;
using System.Reflection;

namespace Task6
{
    public partial class AssemblerForm : Form
    {
        AssemblyInfo ai;
        AboutType type;
        MainForm MF;
        public AssemblerForm(MainForm mf)
        {
            InitializeComponent();
            ai = new AssemblyInfo(typeof(IEdition).GetTypeInfo().Assembly);
            foreach (var type in ai.types)
            {
                    ClassesCB.Items.Add(type.Name);
            }
            ClassesCB.SelectedIndex = 0;
            MF = mf;
        }
      
        private void PropertiesCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClassesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = new AboutType(ai.types[ClassesCB.SelectedIndex]);
            FillComboBox(PropertiesCB, type.GetProperties());
            FillComboBox(MethodsCB, type.GetMethods());
            FillComboBox(InterfacesCB, type.GetInterfaces());
            FillComboBox(ConstructorsCB, type.GetConstructors());
        }
        private void FillComboBox(ComboBox CB, List<string> output)
        {
            CB.Items.Clear();
            foreach (var item in output)
            {
                CB.Items.Add(item);
            }
            CB.SelectedIndex = 0;
        }

        private void NewObjectBttn_Click(object sender, EventArgs e)
        {
            if(type!=null)
            {
                ConstructorInfo ci = type.CurrentType.GetConstructor(new Type[] { });
                object obj = ci.Invoke(new object[] { });
                AddBook ab = new AddBook(type.CurrentType, obj);
               // ab.Show();
                if(ab.ShowDialog() == DialogResult.OK)
                {
                   
                    return;
                }
                if (ab.result != null)
                {
                    obj = ab.result;
                    MF.UpDate(obj);
                    type.CurrentObject = obj;
                }
                //if()
                //ab.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(type !=null)
            {
                int index = MethodsCB.SelectedIndex;
                if (index >= 0 && index < type.Methods.Length)
                {
                    List<Type> types = type.GetParametersOfMethod(index);
                    //List<object> param = InputParams(type.Methods[index].GetParameters()); if (param == null)
                    //    return;
                    object ret = type.RunMethod(index);
                    if(ret != null)
                    MessageBox.Show(ret.ToString());
                    //if (ret != null)
                    //    output.Text = ret.ToString();
                    //else
                    //    output.Text = "";
                    //UpdType();
                }
            }
        }
    }
}
