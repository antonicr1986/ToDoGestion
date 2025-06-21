namespace ToDoGestion.Forms
{
    partial class FormAddTask
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
            labelTitulo = new Label();
            textBoxTitulo = new TextBox();
            textBoxDescripcion = new TextBox();
            labelDescripcion = new Label();
            checkBoxCompletada = new CheckBox();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(52, 49);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(41, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Titulo:";
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(242, 52);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(100, 23);
            textBoxTitulo.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(247, 109);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(100, 23);
            textBoxDescripcion.TabIndex = 2;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Location = new Point(59, 115);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(72, 15);
            labelDescripcion.TabIndex = 3;
            labelDescripcion.Text = "Descripcion:";
            // 
            // checkBoxCompletada
            // 
            checkBoxCompletada.AutoSize = true;
            checkBoxCompletada.Location = new Point(62, 199);
            checkBoxCompletada.Name = "checkBoxCompletada";
            checkBoxCompletada.Size = new Size(101, 19);
            checkBoxCompletada.TabIndex = 4;
            checkBoxCompletada.Text = "¿Completada?";
            checkBoxCompletada.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(264, 344);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 5;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(443, 351);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 6;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // FormAddTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(checkBoxCompletada);
            Controls.Add(labelDescripcion);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxTitulo);
            Controls.Add(labelTitulo);
            Name = "FormAddTask";
            Text = "FormAddTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBoxTitulo;
        private TextBox textBoxDescripcion;
        private Label labelDescripcion;
        private CheckBox checkBoxCompletada;
        private Button buttonGuardar;
        private Button buttonCancelar;
    }
}