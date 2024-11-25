namespace EmpleadosXML
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtPuesto = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox3 = new GroupBox();
            ListaEmpleados = new ListBox();
            AgregarEmpleado = new Button();
            GuardarEmpleado = new Button();
            CargarEmpleado = new Button();
            Salir = new Button();
            LimpiarLista = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(8, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 82);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(164, 23);
            label1.Name = "label1";
            label1.Size = new Size(482, 39);
            label1.TabIndex = 0;
            label1.Text = "Registro De Empleados Con Xml";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPuesto);
            groupBox2.Controls.Add(txtEdad);
            groupBox2.Controls.Add(txtApellido);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(14, 106);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(338, 202);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos";
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(99, 162);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.Size = new Size(125, 27);
            txtPuesto.TabIndex = 9;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(99, 129);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 27);
            txtEdad.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(99, 94);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(99, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(99, 27);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 27);
            txtID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 161);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 4;
            label6.Text = "Puesto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 129);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 3;
            label5.Text = "Edad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 94);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 2;
            label4.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 62);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 1;
            label3.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 30);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(LimpiarLista);
            groupBox3.Controls.Add(ListaEmpleados);
            groupBox3.Location = new Point(371, 120);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(417, 213);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Resultado";
            // 
            // ListaEmpleados
            // 
            ListaEmpleados.FormattingEnabled = true;
            ListaEmpleados.Location = new Point(8, 22);
            ListaEmpleados.Name = "ListaEmpleados";
            ListaEmpleados.Size = new Size(329, 144);
            ListaEmpleados.TabIndex = 0;
            // 
            // AgregarEmpleado
            // 
            AgregarEmpleado.Location = new Point(24, 361);
            AgregarEmpleado.Name = "AgregarEmpleado";
            AgregarEmpleado.Size = new Size(94, 29);
            AgregarEmpleado.TabIndex = 3;
            AgregarEmpleado.Text = "Agregar";
            AgregarEmpleado.UseVisualStyleBackColor = true;
            AgregarEmpleado.Click += AgregarEmpleado_Click;
            // 
            // GuardarEmpleado
            // 
            GuardarEmpleado.Location = new Point(157, 363);
            GuardarEmpleado.Name = "GuardarEmpleado";
            GuardarEmpleado.Size = new Size(94, 29);
            GuardarEmpleado.TabIndex = 4;
            GuardarEmpleado.Text = "Guardar";
            GuardarEmpleado.UseVisualStyleBackColor = true;
            GuardarEmpleado.Click += GuardarEmpleado_Click;
            // 
            // CargarEmpleado
            // 
            CargarEmpleado.Location = new Point(298, 363);
            CargarEmpleado.Name = "CargarEmpleado";
            CargarEmpleado.Size = new Size(94, 29);
            CargarEmpleado.TabIndex = 5;
            CargarEmpleado.Text = "Cargar";
            CargarEmpleado.UseVisualStyleBackColor = true;
            CargarEmpleado.Click += CargarEmpleado_Click;
            // 
            // Salir
            // 
            Salir.Location = new Point(418, 363);
            Salir.Name = "Salir";
            Salir.Size = new Size(94, 29);
            Salir.TabIndex = 6;
            Salir.Text = "Salir";
            Salir.UseVisualStyleBackColor = true;
            Salir.Click += Salir_Click;
            // 
            // LimpiarLista
            // 
            LimpiarLista.Location = new Point(8, 172);
            LimpiarLista.Name = "LimpiarLista";
            LimpiarLista.Size = new Size(94, 29);
            LimpiarLista.TabIndex = 1;
            LimpiarLista.Text = "Limpiar";
            LimpiarLista.UseVisualStyleBackColor = true;
            LimpiarLista.Click += LimpiarLista_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Salir);
            Controls.Add(CargarEmpleado);
            Controls.Add(GuardarEmpleado);
            Controls.Add(AgregarEmpleado);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtID;
        private TextBox txtPuesto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox3;
        private ListBox ListaEmpleados;
        private Button AgregarEmpleado;
        private Button GuardarEmpleado;
        private Button CargarEmpleado;
        private Button Salir;
        private Button LimpiarLista;
    }
}
