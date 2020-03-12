namespace Proyecto_Veterinaria
{
    partial class Jaulas
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
            this.dtjaulas = new System.Windows.Forms.DataGridView();
            this.bus = new System.Windows.Forms.Button();
            this.el = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.ing = new System.Windows.Forms.Button();
            this.dis = new System.Windows.Forms.TextBox();
            this.med = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jaulasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.des = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtjaulas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(65, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 44);
            this.button2.TabIndex = 28;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(726, 403);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(144, 44);
            this.volver.TabIndex = 27;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtjaulas
            // 
            this.dtjaulas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtjaulas.Location = new System.Drawing.Point(405, 54);
            this.dtjaulas.Name = "dtjaulas";
            this.dtjaulas.RowTemplate.Height = 24;
            this.dtjaulas.Size = new System.Drawing.Size(465, 326);
            this.dtjaulas.TabIndex = 26;
            this.dtjaulas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtjaulas_CellClick);
            // 
            // bus
            // 
            this.bus.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus.Location = new System.Drawing.Point(255, 52);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(97, 32);
            this.bus.TabIndex = 25;
            this.bus.Text = "Buscar";
            this.bus.UseVisualStyleBackColor = true;
            // 
            // el
            // 
            this.el.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.el.Location = new System.Drawing.Point(564, 403);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(144, 44);
            this.el.TabIndex = 24;
            this.el.Text = "Eliminar";
            this.el.UseVisualStyleBackColor = true;
            this.el.Click += new System.EventHandler(this.el_Click);
            // 
            // mod
            // 
            this.mod.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.Location = new System.Drawing.Point(405, 403);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(144, 44);
            this.mod.TabIndex = 23;
            this.mod.Text = "Modificar";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // ing
            // 
            this.ing.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ing.Location = new System.Drawing.Point(236, 403);
            this.ing.Name = "ing";
            this.ing.Size = new System.Drawing.Size(144, 44);
            this.ing.TabIndex = 22;
            this.ing.Text = "Ingresar";
            this.ing.UseVisualStyleBackColor = true;
            this.ing.Click += new System.EventHandler(this.ing_Click);
            // 
            // dis
            // 
            this.dis.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dis.Location = new System.Drawing.Point(175, 159);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(66, 28);
            this.dis.TabIndex = 21;
            this.dis.Text = "Si";
            this.dis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // med
            // 
            this.med.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med.Location = new System.Drawing.Point(173, 105);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(100, 28);
            this.med.TabIndex = 20;
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(173, 54);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(68, 28);
            this.id.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Disponibilidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Medida";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Identificador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.ingresarToolStripMenuItem.Text = "Ingresar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.buscarToolStripMenuItem.Text = "Buscar";
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            // 
            // jaulasToolStripMenuItem
            // 
            this.jaulasToolStripMenuItem.Name = "jaulasToolStripMenuItem";
            this.jaulasToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.jaulasToolStripMenuItem.Text = "Jaulas";
            this.jaulasToolStripMenuItem.Click += new System.EventHandler(this.jaulasToolStripMenuItem_Click);
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.especiesToolStripMenuItem.Text = "Especies";
            // 
            // razasToolStripMenuItem
            // 
            this.razasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarToolStripMenuItem5,
            this.modificarToolStripMenuItem5,
            this.eliminarToolStripMenuItem5,
            this.buscarToolStripMenuItem5});
            this.razasToolStripMenuItem.Name = "razasToolStripMenuItem";
            this.razasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.razasToolStripMenuItem.Text = "Razas";
            // 
            // ingresarToolStripMenuItem5
            // 
            this.ingresarToolStripMenuItem5.Name = "ingresarToolStripMenuItem5";
            this.ingresarToolStripMenuItem5.Size = new System.Drawing.Size(148, 26);
            this.ingresarToolStripMenuItem5.Text = "Ingresar";
            // 
            // modificarToolStripMenuItem5
            // 
            this.modificarToolStripMenuItem5.Name = "modificarToolStripMenuItem5";
            this.modificarToolStripMenuItem5.Size = new System.Drawing.Size(148, 26);
            this.modificarToolStripMenuItem5.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem5
            // 
            this.eliminarToolStripMenuItem5.Name = "eliminarToolStripMenuItem5";
            this.eliminarToolStripMenuItem5.Size = new System.Drawing.Size(148, 26);
            this.eliminarToolStripMenuItem5.Text = "Eliminar";
            // 
            // buscarToolStripMenuItem5
            // 
            this.buscarToolStripMenuItem5.Name = "buscarToolStripMenuItem5";
            this.buscarToolStripMenuItem5.Size = new System.Drawing.Size(148, 26);
            this.buscarToolStripMenuItem5.Text = "Buscar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.salirToolStripMenuItem.Text = "                                  ";
            // 
            // des
            // 
            this.des.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.des.Location = new System.Drawing.Point(175, 209);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(205, 28);
            this.des.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "Descripcion";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // Jaulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.des);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.dtjaulas);
            this.Controls.Add(this.bus);
            this.Controls.Add(this.el);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.ing);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.med);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Jaulas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jaulas";
            this.Load += new System.EventHandler(this.Jaulas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtjaulas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.DataGridView dtjaulas;
        private System.Windows.Forms.Button bus;
        private System.Windows.Forms.Button el;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button ing;
        private System.Windows.Forms.TextBox dis;
        private System.Windows.Forms.TextBox med;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem jaulasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}