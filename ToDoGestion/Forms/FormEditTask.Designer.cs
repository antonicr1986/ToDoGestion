namespace ToDoGestion.Forms
{
    partial class FormEditTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditTask));
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            checkBoxCompletada = new CheckBox();
            labelDescripcion = new Label();
            textBoxDescripcion = new TextBox();
            textBoxTitulo = new TextBox();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(376, 193);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 13;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += btnCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(247, 193);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 12;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += btnGuardar_Click;
            // 
            // checkBoxCompletada
            // 
            checkBoxCompletada.AutoSize = true;
            checkBoxCompletada.Location = new Point(60, 162);
            checkBoxCompletada.Name = "checkBoxCompletada";
            checkBoxCompletada.Size = new Size(101, 19);
            checkBoxCompletada.TabIndex = 11;
            checkBoxCompletada.Text = "¿Completada?";
            checkBoxCompletada.UseVisualStyleBackColor = true;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(60, 100);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(72, 15);
            labelDescripcion.TabIndex = 10;
            labelDescripcion.Text = "Descripcion:";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(247, 92);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(204, 23);
            textBoxDescripcion.TabIndex = 9;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(250, 40);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(201, 23);
            textBoxTitulo.TabIndex = 8;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(60, 37);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(41, 15);
            labelTitulo.TabIndex = 7;
            labelTitulo.Text = "Titulo:";
            // 
            // FormEditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(514, 277);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(checkBoxCompletada);
            Controls.Add(labelDescripcion);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormEditTask";
            Text = "Editar tarea";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonGuardar;
        private CheckBox checkBoxCompletada;
        private Label labelDescripcion;
        private TextBox textBoxDescripcion;
        private TextBox textBoxTitulo;
        private Label labelTitulo;
    }
}