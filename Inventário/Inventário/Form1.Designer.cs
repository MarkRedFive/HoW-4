
namespace Inventário
{
    partial class inventario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario));
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verColdreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verMochilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAlgibeiraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbID = new System.Windows.Forms.TextBox();
            this.dgvItem = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTipo = new System.Windows.Forms.TextBox();
            this.tbLocal = new System.Windows.Forms.TextBox();
            this.tbPeso = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btDrop = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbLocalExtra1 = new System.Windows.Forms.TextBox();
            this.tbLocalExtra2 = new System.Windows.Forms.TextBox();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.ver4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ver5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAdd.Location = new System.Drawing.Point(8, 102);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(136, 47);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Adicionar ao Inventário";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verTodosToolStripMenuItem,
            this.verMochilaToolStripMenuItem,
            this.verAlgibeiraToolStripMenuItem,
            this.verColdreToolStripMenuItem,
            this.verTodosToolStripMenuItem1,
            this.ver4ToolStripMenuItem,
            this.ver5ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verColdreToolStripMenuItem
            // 
            this.verColdreToolStripMenuItem.Name = "verColdreToolStripMenuItem";
            this.verColdreToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.verColdreToolStripMenuItem.Text = "Ver coldre";
            this.verColdreToolStripMenuItem.Click += new System.EventHandler(this.verColdreToolStripMenuItem_Click);
            // 
            // verMochilaToolStripMenuItem
            // 
            this.verMochilaToolStripMenuItem.Name = "verMochilaToolStripMenuItem";
            this.verMochilaToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.verMochilaToolStripMenuItem.Text = "Ver mochila";
            this.verMochilaToolStripMenuItem.Click += new System.EventHandler(this.verMochilaToolStripMenuItem_Click);
            // 
            // verAlgibeiraToolStripMenuItem
            // 
            this.verAlgibeiraToolStripMenuItem.Name = "verAlgibeiraToolStripMenuItem";
            this.verAlgibeiraToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.verAlgibeiraToolStripMenuItem.Text = "Ver algibeira";
            this.verAlgibeiraToolStripMenuItem.Click += new System.EventHandler(this.verAlgibeiraToolStripMenuItem_Click);
            // 
            // verTodosToolStripMenuItem
            // 
            this.verTodosToolStripMenuItem.Name = "verTodosToolStripMenuItem";
            this.verTodosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.verTodosToolStripMenuItem.Text = "Ver chão";
            this.verTodosToolStripMenuItem.Click += new System.EventHandler(this.verTodosToolStripMenuItem_Click);
            // 
            // verTodosToolStripMenuItem1
            // 
            this.verTodosToolStripMenuItem1.Name = "verTodosToolStripMenuItem1";
            this.verTodosToolStripMenuItem1.Size = new System.Drawing.Size(69, 20);
            this.verTodosToolStripMenuItem1.Text = "Ver todos";
            this.verTodosToolStripMenuItem1.Click += new System.EventHandler(this.verTodosToolStripMenuItem1_Click);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(310, 53);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(104, 20);
            this.tbID.TabIndex = 3;
            // 
            // dgvItem
            // 
            this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNome,
            this.ColTipo,
            this.ColQuantidade,
            this.ColPeso,
            this.ColValor,
            this.ColDescricao,
            this.ColLocal});
            this.dgvItem.Location = new System.Drawing.Point(8, 155);
            this.dgvItem.Name = "dgvItem";
            this.dgvItem.Size = new System.Drawing.Size(859, 249);
            this.dgvItem.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Local:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Peso:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(356, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Descrição:";
            // 
            // tbTipo
            // 
            this.tbTipo.Location = new System.Drawing.Point(44, 53);
            this.tbTipo.Name = "tbTipo";
            this.tbTipo.Size = new System.Drawing.Size(100, 20);
            this.tbTipo.TabIndex = 12;
            // 
            // tbLocal
            // 
            this.tbLocal.Location = new System.Drawing.Point(44, 76);
            this.tbLocal.Name = "tbLocal";
            this.tbLocal.Size = new System.Drawing.Size(100, 20);
            this.tbLocal.TabIndex = 13;
            // 
            // tbPeso
            // 
            this.tbPeso.Location = new System.Drawing.Point(187, 53);
            this.tbPeso.Name = "tbPeso";
            this.tbPeso.Size = new System.Drawing.Size(94, 20);
            this.tbPeso.TabIndex = 14;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(44, 30);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(306, 20);
            this.tbNome.TabIndex = 15;
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(218, 76);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(63, 20);
            this.tbQuantidade.TabIndex = 16;
            // 
            // tbValor
            // 
            this.tbValor.Location = new System.Drawing.Point(321, 76);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(93, 20);
            this.tbValor.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(258, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "KG";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(391, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "PO";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Enabled = false;
            this.tbDescricao.Location = new System.Drawing.Point(420, 30);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(447, 66);
            this.tbDescricao.TabIndex = 20;
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAlterar.Location = new System.Drawing.Point(150, 102);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(136, 47);
            this.btAlterar.TabIndex = 21;
            this.btAlterar.Text = "Alterar o Inventário";
            this.btAlterar.UseVisualStyleBackColor = false;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDelete.Location = new System.Drawing.Point(292, 102);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(136, 47);
            this.btDelete.TabIndex = 22;
            this.btDelete.Text = "Quebrar";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.Khaki;
            this.btLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLimpar.Location = new System.Drawing.Point(566, 102);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(94, 47);
            this.btLimpar.TabIndex = 23;
            this.btLimpar.Text = "Limpar Campos";
            this.btLimpar.UseVisualStyleBackColor = false;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btDrop
            // 
            this.btDrop.BackColor = System.Drawing.Color.Fuchsia;
            this.btDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btDrop.Location = new System.Drawing.Point(500, 102);
            this.btDrop.Name = "btDrop";
            this.btDrop.Size = new System.Drawing.Size(60, 47);
            this.btDrop.TabIndex = 24;
            this.btDrop.Text = "Jogar no Chão";
            this.btDrop.UseVisualStyleBackColor = false;
            this.btDrop.Click += new System.EventHandler(this.btDrop_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(666, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "0 =   CHÃO";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(767, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "1 =   MOCHILA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(666, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "2 =   ALGIBEIRA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(767, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "3 =   COLDRE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(767, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "5 =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(666, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "4 =";
            // 
            // tbLocalExtra1
            // 
            this.tbLocalExtra1.Location = new System.Drawing.Point(689, 133);
            this.tbLocalExtra1.Name = "tbLocalExtra1";
            this.tbLocalExtra1.Size = new System.Drawing.Size(72, 20);
            this.tbLocalExtra1.TabIndex = 31;
            // 
            // tbLocalExtra2
            // 
            this.tbLocalExtra2.Location = new System.Drawing.Point(792, 133);
            this.tbLocalExtra2.Name = "tbLocalExtra2";
            this.tbLocalExtra2.Size = new System.Drawing.Size(72, 20);
            this.tbLocalExtra2.TabIndex = 32;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            this.ColNome.Width = 150;
            // 
            // ColTipo
            // 
            this.ColTipo.HeaderText = "Tipo";
            this.ColTipo.Name = "ColTipo";
            // 
            // ColQuantidade
            // 
            this.ColQuantidade.HeaderText = "Quant";
            this.ColQuantidade.Name = "ColQuantidade";
            this.ColQuantidade.Width = 40;
            // 
            // ColPeso
            // 
            this.ColPeso.HeaderText = "Peso";
            this.ColPeso.Name = "ColPeso";
            this.ColPeso.Width = 40;
            // 
            // ColValor
            // 
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.Width = 60;
            // 
            // ColDescricao
            // 
            this.ColDescricao.HeaderText = "Descrição";
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.Width = 350;
            // 
            // ColLocal
            // 
            this.ColLocal.HeaderText = "Local";
            this.ColLocal.Name = "ColLocal";
            this.ColLocal.Width = 75;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(434, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 47);
            this.button1.TabIndex = 33;
            this.button1.Text = "Pegar do Chão";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ver4ToolStripMenuItem
            // 
            this.ver4ToolStripMenuItem.Name = "ver4ToolStripMenuItem";
            this.ver4ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ver4ToolStripMenuItem.Text = "Ver 4";
            this.ver4ToolStripMenuItem.Click += new System.EventHandler(this.ver4ToolStripMenuItem_Click);
            // 
            // ver5ToolStripMenuItem
            // 
            this.ver5ToolStripMenuItem.Name = "ver5ToolStripMenuItem";
            this.ver5ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ver5ToolStripMenuItem.Text = "Ver 5";
            this.ver5ToolStripMenuItem.Click += new System.EventHandler(this.ver5ToolStripMenuItem_Click);
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLocalExtra2);
            this.Controls.Add(this.tbLocalExtra1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btDrop);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.tbQuantidade);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbPeso);
            this.Controls.Add(this.tbLocal);
            this.Controls.Add(this.tbTipo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvItem);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "inventario";
            this.Text = "Tabela de Inventário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verColdreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verMochilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAlgibeiraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTodosToolStripMenuItem;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTipo;
        private System.Windows.Forms.TextBox tbLocal;
        private System.Windows.Forms.TextBox tbPeso;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbValor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btDrop;
        private System.Windows.Forms.ToolStripMenuItem verTodosToolStripMenuItem1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbLocalExtra1;
        private System.Windows.Forms.TextBox tbLocalExtra2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ver4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ver5ToolStripMenuItem;
    }
}

