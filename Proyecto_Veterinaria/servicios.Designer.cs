namespace Proyecto_Veterinaria
{
    partial class servicios
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
            this.button2 = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.dtservicios = new System.Windows.Forms.DataGridView();
            this.bus = new System.Windows.Forms.Button();
            this.el = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.ing = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.pre = new System.Windows.Forms.TextBox();
            this.des = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtservicios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(65, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 44);
            this.button2.TabIndex = 36;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(726, 406);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(144, 44);
            this.volver.TabIndex = 35;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // dtservicios
            // 
            this.dtservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtservicios.Location = new System.Drawing.Point(405, 57);
            this.dtservicios.Name = "dtservicios";
            this.dtservicios.RowTemplate.Height = 24;
            this.dtservicios.Size = new System.Drawing.Size(465, 326);
            this.dtservicios.TabIndex = 34;
            this.dtservicios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtservicios_CellClick_1);
            // 
            // bus
            // 
            this.bus.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus.Location = new System.Drawing.Point(255, 55);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(97, 32);
            this.bus.TabIndex = 33;
            this.bus.Text = "Buscar";
            this.bus.UseVisualStyleBackColor = true;
            // 
            // el
            // 
            this.el.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.el.Location = new System.Drawing.Point(564, 406);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(144, 44);
            this.el.TabIndex = 32;
            this.el.Text = "Eliminar";
            this.el.UseVisualStyleBackColor = true;
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.Location = new System.Drawing.Point(405, 406);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(144, 44);
            this.mod.TabIndex = 31;
            this.mod.Text = "Modificar";
            this.mod.UseVisualStyleBackColor = true;
            // 
            // ing
            // 
            this.ing.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ing.Location = new System.Drawing.Point(236, 406);
            this.ing.Name = "ing";
            this.ing.Size = new System.Drawing.Size(144, 44);
            this.ing.TabIndex = 30;
            this.ing.Text = "Ingresar";
            this.ing.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.jaulasToolStripMenuItem,
            this.especiesToolStripMenuItem,
            this.razasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // jaulasToolStripMenuItem
            // 
            this.jaulasToolStripMenuItem.Name = "jaulasToolStripMenuItem";
            this.jaulasToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.jaulasToolStripMenuItem.Text = "Jaulas";
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.especiesToolStripMenuItem.Text = "Especies";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.salirToolStripMenuItem.Text = "                                  ";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // razasToolStripMenuItem
            // 
            this.razasToolStripMenuItem.Name = "razasToolStripMenuItem";
            this.razasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.razasToolStripMenuItem.Text = "Razas";
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(167, 57);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(68, 28);
            this.id.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "Identificador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "Descripcion";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(167, 100);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(232, 28);
            this.nom.TabIndex = 42;
            // 
            // pre
            // 
            this.pre.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pre.Location = new System.Drawing.Point(167, 144);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(105, 28);
            this.pre.TabIndex = 43;
            // 
            // des
            // 
            this.des.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.Location = new System.Drawing.Point(167, 190);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(232, 28);
            this.des.TabIndex = 44;
            // 
            // servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.des);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.dtservicios);
            this.Controls.Add(this.bus);
            this.Controls.Add(this.el);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.ing);
            this.Controls.Add(this.menuStrip1);
            this.Name = "servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "servicios";
            this.Load += new System.EventHandler(this.servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtservicios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.DataGridView dtservicios;
        private System.Windows.Forms.Button bus;
        private System.Windows.Forms.Button el;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button ing;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jaulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razasToolStripMenuItem;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox pre;
        private System.Windows.Forms.TextBox des;
    }
}