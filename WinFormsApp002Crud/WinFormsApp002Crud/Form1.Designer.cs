namespace WinFormsApp002Crud
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
            dgvCervezas = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCervezas).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCervezas
            // 
            dgvCervezas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCervezas.Location = new Point(12, 12);
            dgvCervezas.Name = "dgvCervezas";
            dgvCervezas.Size = new Size(477, 219);
            dgvCervezas.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Location = new Point(495, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(192, 219);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Acciones";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(47, 136);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 24);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(47, 86);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 24);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(47, 38);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(120, 24);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 243);
            Controls.Add(groupBox1);
            Controls.Add(dgvCervezas);
            Name = "Form1";
            Text = "CRUD Cervezas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCervezas).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCervezas;
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
    }
}
