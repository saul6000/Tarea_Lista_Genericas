namespace Tarea_ListaGénericas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.gridAsignatura = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btbAgregar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listMatriculas = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btbMostrar = new System.Windows.Forms.Button();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtMaxima = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignatura)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MATRICULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "APELLIDOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(938, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SEXO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "EDAD";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(12, 58);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(146, 22);
            this.txtMatricula.TabIndex = 5;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtCarrera_TextChanged);
            this.txtMatricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarrera_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombres.Location = new System.Drawing.Point(191, 58);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(267, 22);
            this.txtNombres.TabIndex = 6;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtApellidos
            // 
            this.txtApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidos.Location = new System.Drawing.Point(474, 58);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(211, 22);
            this.txtApellidos.TabIndex = 7;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidos_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(702, 58);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(149, 22);
            this.txtEdad.TabIndex = 8;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // txtSexo
            // 
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "Masculino ",
            "Femenino ",
            "Otros... "});
            this.txtSexo.Location = new System.Drawing.Point(880, 58);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(170, 23);
            this.txtSexo.TabIndex = 9;
            this.txtSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSexo_KeyPress);
            // 
            // gridAsignatura
            // 
            this.gridAsignatura.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gridAsignatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsignatura.Location = new System.Drawing.Point(12, 118);
            this.gridAsignatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridAsignatura.Name = "gridAsignatura";
            this.gridAsignatura.RowHeadersWidth = 51;
            this.gridAsignatura.RowTemplate.Height = 24;
            this.gridAsignatura.Size = new System.Drawing.Size(784, 141);
            this.gridAsignatura.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "LISTADO DE MATRICULAS";
            // 
            // btbAgregar
            // 
            this.btbAgregar.Location = new System.Drawing.Point(842, 155);
            this.btbAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbAgregar.Name = "btbAgregar";
            this.btbAgregar.Size = new System.Drawing.Size(175, 66);
            this.btbAgregar.TabIndex = 12;
            this.btbAgregar.Text = "Agregar";
            this.btbAgregar.UseVisualStyleBackColor = true;
            this.btbAgregar.Click += new System.EventHandler(this.btbAgregar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(377, 267);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(95, 28);
            this.btnFiltrar.TabIndex = 13;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 270);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "FILTRAR POR MATRICULA";
            // 
            // listMatriculas
            // 
            this.listMatriculas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listMatriculas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listMatriculas.HideSelection = false;
            this.listMatriculas.Location = new System.Drawing.Point(3, 344);
            this.listMatriculas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listMatriculas.Name = "listMatriculas";
            this.listMatriculas.Size = new System.Drawing.Size(839, 126);
            this.listMatriculas.TabIndex = 16;
            this.listMatriculas.UseCompatibleStateImageBehavior = false;
            this.listMatriculas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MATRICULA";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "NOMBRES";
            this.columnHeader2.Width = 246;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "APELLIDOS";
            this.columnHeader3.Width = 238;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "EDAD";
            this.columnHeader4.Width = 104;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SEXO";
            this.columnHeader5.Width = 127;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "LISTADO DE MATRICULAS";
            // 
            // btbMostrar
            // 
            this.btbMostrar.Location = new System.Drawing.Point(940, 282);
            this.btbMostrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btbMostrar.Name = "btbMostrar";
            this.btbMostrar.Size = new System.Drawing.Size(110, 41);
            this.btbMostrar.TabIndex = 18;
            this.btbMostrar.Text = "Mostrar";
            this.btbMostrar.UseVisualStyleBackColor = true;
            this.btbMostrar.Click += new System.EventHandler(this.btbMostrar_Click);
            // 
            // txtMinimo
            // 
            this.txtMinimo.Location = new System.Drawing.Point(788, 301);
            this.txtMinimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(135, 22);
            this.txtMinimo.TabIndex = 19;
            // 
            // txtMaxima
            // 
            this.txtMaxima.Location = new System.Drawing.Point(788, 271);
            this.txtMaxima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaxima.Name = "txtMaxima";
            this.txtMaxima.Size = new System.Drawing.Size(135, 22);
            this.txtMaxima.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(667, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "EDAD MAXIMA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "EDAD MINIMA";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(871, 395);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(83, 41);
            this.btnBorrar.TabIndex = 23;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(960, 395);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(81, 41);
            this.btn.TabIndex = 24;
            this.btn.Text = "Limpiar ";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1078, 492);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMaxima);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.btbMostrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listMatriculas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btbAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridAsignatura);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tarea Lista Genericas ";
            ((System.ComponentModel.ISupportInitialize)(this.gridAsignatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.DataGridView gridAsignatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbAgregar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listMatriculas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btbMostrar;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtMaxima;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btn;
    }
}

