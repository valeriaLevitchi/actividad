using System.Windows.Forms;

namespace actividad1_02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label24 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            texto1 = new TextBox();
            texto2 = new TextBox();
            botonsito = new Button();
            fechastexto = new Label();
            dateTimePicker1 = new DateTimePicker();
            penel = new Panel();
            tiposarchivos = new CheckedListBox();
            checkedListBox1 = new CheckedListBox();
            comentarios = new Label();
            sino = new CheckedListBox();
            penel.SuspendLayout();
            SuspendLayout();
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(33, 39);
            label24.Name = "label24";
            label24.Size = new Size(111, 15);
            label24.TabIndex = 0;
            label24.Text = "Nombre de la tarea ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 76);
            label2.Name = "label2";
            label2.Size = new Size(129, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción de la tarea ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 195);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de entrega ";
          
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 252);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo de entrega ";
           
            // 
            // texto1
            // 
            texto1.Location = new Point(195, 36);
            texto1.Name = "texto1";
            texto1.Size = new Size(285, 23);
            texto1.TabIndex = 4;
            // 
            // texto2
            // 
            texto2.Anchor = AnchorStyles.None;
            texto2.Location = new Point(195, 73);
            texto2.MinimumSize = new Size(0, 50);
            texto2.Multiline = true;
            texto2.Name = "texto2";
            texto2.Size = new Size(367, 100);
            texto2.TabIndex = 5;
            // 
            // botonsito
            // 
            botonsito.Location = new Point(264, 454);
            botonsito.Name = "botonsito";
            botonsito.Size = new Size(154, 23);
            botonsito.TabIndex = 7;
            botonsito.Text = "actividad creada";
            botonsito.UseVisualStyleBackColor = true;
            botonsito.Click += button1_Click;
            // 
            // fechastexto
            // 
            fechastexto.AutoSize = true;
            fechastexto.Location = new Point(324, 372);
            fechastexto.Name = "fechastexto";
            fechastexto.Size = new Size(0, 15);
            fechastexto.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(195, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(276, 23);
            dateTimePicker1.TabIndex = 9;
           
            // 
            // penel
            // 
            penel.Controls.Add(tiposarchivos);
            penel.Location = new Point(324, 255);
            penel.Name = "penel";
            penel.Size = new Size(137, 100);
            penel.TabIndex = 10;
            // 
            // tiposarchivos
            // 
            tiposarchivos.FormattingEnabled = true;
            tiposarchivos.Items.AddRange(new object[] { "pipi con", "nutela", "cloroformo" });
            tiposarchivos.Location = new Point(9, 6);
            tiposarchivos.Name = "tiposarchivos";
            tiposarchivos.Size = new Size(120, 94);
            tiposarchivos.TabIndex = 0;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "pajas locas", "coin gasolina ", "y matamosquitos" });
            checkedListBox1.Location = new Point(186, 261);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 11;
           
            // 
            // comentarios
            // 
            comentarios.AutoSize = true;
            comentarios.Location = new Point(68, 395);
            comentarios.Name = "comentarios";
            comentarios.Size = new Size(78, 15);
            comentarios.TabIndex = 12;
            comentarios.Text = "te gusta el pn";
            // 
            // sino
            // 
            sino.FormattingEnabled = true;
            sino.Items.AddRange(new object[] { "si", "no" });
            sino.Location = new Point(186, 394);
            sino.Name = "sino";
            sino.Size = new Size(120, 40);
            sino.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 519);
            Controls.Add(sino);
            Controls.Add(comentarios);
            Controls.Add(checkedListBox1);
            Controls.Add(penel);
            Controls.Add(dateTimePicker1);
            Controls.Add(fechastexto);
            Controls.Add(botonsito);
            Controls.Add(texto2);
            Controls.Add(texto1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label24);
            Name = "Form1";
            Text = "Form1";
            penel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label24;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox texto1;
        private TextBox texto2;
        private Button botonsito;
        private Label fechastexto;
        private DateTimePicker dateTimePicker1;
        private Panel penel;
        private CheckedListBox checkedListBox1;
        private CheckedListBox tiposarchivos;
        private Label comentarios;
        private CheckedListBox sino;
    }
}