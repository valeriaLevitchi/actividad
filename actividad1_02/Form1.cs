using System.Windows.Forms;

namespace actividad1_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //para que el panel no se vea
            penel.Visible = false;
            checkedListBox1.ItemCheck += (sender, e) =>
            {
                // para evitar que haga multiple selecion
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                }
            };

            tiposarchivos.ItemCheck += (sender, e) =>
            {
                
                for (int i = 0; i < tiposarchivos.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        tiposarchivos.SetItemChecked(i, false);
                    }
                }
            };

            sino.ItemCheck += (sender, e) =>
            {
                for (int i = 0; i < sino.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        sino.SetItemChecked(i, false);
                    }
                }
            };

            checkedListBox1.ItemCheck += (sender, e) =>
            {
                // para mostrar panel
                penel.Visible = (e.Index == 0);
            };

        }

       //en el boton se recopila toda la info 
       //comprobar integridad datos 

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = false;
            DateTime theDate = dateTimePicker1.Value;

            string nombre = texto1.Text;

            string descripcion = texto2.Text;

            bool alMenosUnaMarcada = false;

            //los for sirven para comprobar que hay una casilla marcada si no salta error 
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    alMenosUnaMarcada = true;
                    break;
                }
            }
            if (!alMenosUnaMarcada)

            {
                error = true;
                MessageBox.Show("MArca una casilla en los formatos de entrega");
                
            }
            bool alMenosUnaMarcada2 = false;

            if (penel.Visible)
            {

                

                for (int i = 0; i < tiposarchivos.Items.Count; i++)
                {
                    if (tiposarchivos.GetItemChecked(i))
                    {
                        alMenosUnaMarcada2 = true;
                        break;
                    }
                }

                if (!alMenosUnaMarcada2)
                {
                    error = true;
                    MessageBox.Show("MArca una casilla en los tipos de archivos");
                }

            }


            bool alMenosUnaMarcada3 = false;

                for (int i = 0; i < sino.Items.Count; i++)
                {
                    if (sino.GetItemChecked(i))
                    {
                        alMenosUnaMarcada3 = true;
                        break;
                    }
                }

                //comprobar que los campos de texto no esten vacios 

            if (!alMenosUnaMarcada3)
            {
                error = true;
                MessageBox.Show("MArca una casilla en los comentarios");
            }

            if (string.IsNullOrEmpty(nombre))
            {
                error = true;
                MessageBox.Show("ingresa nombre de la actividad.");
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                error = true;
                MessageBox.Show("ingresa descripcion de la actividad.");
            }
            // si todo esta bn suelta este mensaje 
            if (!error)
            {
                MessageBox.Show("Actividad creada");
            }


        }

       


    }
}