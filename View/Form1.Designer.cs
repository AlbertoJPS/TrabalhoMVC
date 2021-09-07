
namespace TrabalhoMVC_02
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
        private  void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Rodada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Palavra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acertos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pontos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPalavra = new System.Windows.Forms.Label();
            this.textBoxPalavra = new System.Windows.Forms.TextBox();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonResetar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.matrix1 = new System.Windows.Forms.Button();
            this.matrix3 = new System.Windows.Forms.Button();
            this.matrix2 = new System.Windows.Forms.Button();
            this.matrix4 = new System.Windows.Forms.Button();
            this.matrix5 = new System.Windows.Forms.Button();
            this.matrix6 = new System.Windows.Forms.Button();
            this.matrix7 = new System.Windows.Forms.Button();
            this.matrix8 = new System.Windows.Forms.Button();
            this.matrix9 = new System.Windows.Forms.Button();
            this.labelApresentacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("FFF Tusj", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(88, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(438, 56);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "CAÇA PALAVRAS";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rodada,
            this.Palavra,
            this.Acertos,
            this.Pontos});
            this.dataGridView.GridColor = System.Drawing.Color.SpringGreen;
            this.dataGridView.Location = new System.Drawing.Point(29, 86);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(546, 197);
            this.dataGridView.TabIndex = 100;
            this.dataGridView.TabStop = false;
            // 
            // Rodada
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Immortal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SpringGreen;
            this.Rodada.DefaultCellStyle = dataGridViewCellStyle1;
            this.Rodada.HeaderText = "Rodada";
            this.Rodada.MaxInputLength = 1000;
            this.Rodada.Name = "Rodada";
            this.Rodada.ReadOnly = true;
            // 
            // Palavra
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Immortal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.SpringGreen;
            this.Palavra.DefaultCellStyle = dataGridViewCellStyle2;
            this.Palavra.HeaderText = "Palavra";
            this.Palavra.MaxInputLength = 6;
            this.Palavra.Name = "Palavra";
            this.Palavra.ReadOnly = true;
            this.Palavra.Width = 200;
            // 
            // Acertos
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Immortal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.SpringGreen;
            this.Acertos.DefaultCellStyle = dataGridViewCellStyle3;
            this.Acertos.HeaderText = "Acertos";
            this.Acertos.MaxInputLength = 1000;
            this.Acertos.Name = "Acertos";
            this.Acertos.ReadOnly = true;
            // 
            // Pontos
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Immortal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.SpringGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.SpringGreen;
            this.Pontos.DefaultCellStyle = dataGridViewCellStyle4;
            this.Pontos.HeaderText = "Pontos";
            this.Pontos.MaxInputLength = 1000;
            this.Pontos.Name = "Pontos";
            this.Pontos.ReadOnly = true;
            // 
            // labelPalavra
            // 
            this.labelPalavra.AutoSize = true;
            this.labelPalavra.BackColor = System.Drawing.Color.Transparent;
            this.labelPalavra.Font = new System.Drawing.Font("FFF Tusj", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPalavra.Location = new System.Drawing.Point(246, 308);
            this.labelPalavra.Name = "labelPalavra";
            this.labelPalavra.Size = new System.Drawing.Size(329, 31);
            this.labelPalavra.TabIndex = 1;
            this.labelPalavra.Text = "DIGITE UMA PALAVRA";
            // 
            // textBoxPalavra
            // 
            this.textBoxPalavra.BackColor = System.Drawing.Color.Black;
            this.textBoxPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPalavra.Font = new System.Drawing.Font("Immortal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxPalavra.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxPalavra.Location = new System.Drawing.Point(246, 342);
            this.textBoxPalavra.MaxLength = 6;
            this.textBoxPalavra.Name = "textBoxPalavra";
            this.textBoxPalavra.PlaceholderText = "<<< ESCREVA AQUI >>>";
            this.textBoxPalavra.Size = new System.Drawing.Size(329, 31);
            this.textBoxPalavra.TabIndex = 2;
            this.textBoxPalavra.Tag = "";
            this.textBoxPalavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPalavra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPalavra_KeyPress);
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonIniciar.Font = new System.Drawing.Font("FFF Tusj", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonIniciar.ForeColor = System.Drawing.Color.Black;
            this.buttonIniciar.Location = new System.Drawing.Point(246, 379);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(329, 50);
            this.buttonIniciar.TabIndex = 3;
            this.buttonIniciar.Text = "INICIAR CAÇA";
            this.buttonIniciar.UseVisualStyleBackColor = false;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonResetar
            // 
            this.buttonResetar.BackColor = System.Drawing.Color.DarkRed;
            this.buttonResetar.Font = new System.Drawing.Font("Immortal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonResetar.ForeColor = System.Drawing.Color.Cyan;
            this.buttonResetar.Location = new System.Drawing.Point(246, 454);
            this.buttonResetar.Name = "buttonResetar";
            this.buttonResetar.Size = new System.Drawing.Size(155, 33);
            this.buttonResetar.TabIndex = 4;
            this.buttonResetar.Text = "RESETAR";
            this.buttonResetar.UseVisualStyleBackColor = false;
            this.buttonResetar.Click += new System.EventHandler(this.buttonResetar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.DarkRed;
            this.buttonSair.Font = new System.Drawing.Font("Immortal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSair.ForeColor = System.Drawing.Color.Yellow;
            this.buttonSair.Location = new System.Drawing.Point(420, 454);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(155, 33);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "SAIR";
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // matrix1
            // 
            this.matrix1.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix1.Enabled = false;
            this.matrix1.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix1.ForeColor = System.Drawing.Color.Black;
            this.matrix1.Location = new System.Drawing.Point(29, 313);
            this.matrix1.Name = "matrix1";
            this.matrix1.Size = new System.Drawing.Size(64, 58);
            this.matrix1.TabIndex = 10;
            this.matrix1.Text = "1";
            this.matrix1.UseVisualStyleBackColor = false;
            // 
            // matrix3
            // 
            this.matrix3.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix3.Enabled = false;
            this.matrix3.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix3.ForeColor = System.Drawing.Color.Black;
            this.matrix3.Location = new System.Drawing.Point(157, 313);
            this.matrix3.Name = "matrix3";
            this.matrix3.Size = new System.Drawing.Size(64, 58);
            this.matrix3.TabIndex = 30;
            this.matrix3.Text = "3";
            this.matrix3.UseVisualStyleBackColor = false;
            // 
            // matrix2
            // 
            this.matrix2.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix2.Enabled = false;
            this.matrix2.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix2.ForeColor = System.Drawing.Color.Black;
            this.matrix2.Location = new System.Drawing.Point(93, 313);
            this.matrix2.Name = "matrix2";
            this.matrix2.Size = new System.Drawing.Size(64, 58);
            this.matrix2.TabIndex = 20;
            this.matrix2.Text = "2";
            this.matrix2.UseVisualStyleBackColor = false;
            // 
            // matrix4
            // 
            this.matrix4.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix4.Enabled = false;
            this.matrix4.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix4.ForeColor = System.Drawing.Color.Black;
            this.matrix4.Location = new System.Drawing.Point(29, 371);
            this.matrix4.Name = "matrix4";
            this.matrix4.Size = new System.Drawing.Size(64, 58);
            this.matrix4.TabIndex = 40;
            this.matrix4.Text = "4";
            this.matrix4.UseVisualStyleBackColor = false;
            // 
            // matrix5
            // 
            this.matrix5.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix5.Enabled = false;
            this.matrix5.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix5.ForeColor = System.Drawing.Color.Black;
            this.matrix5.Location = new System.Drawing.Point(93, 371);
            this.matrix5.Name = "matrix5";
            this.matrix5.Size = new System.Drawing.Size(64, 58);
            this.matrix5.TabIndex = 50;
            this.matrix5.Text = "5";
            this.matrix5.UseVisualStyleBackColor = false;
            // 
            // matrix6
            // 
            this.matrix6.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix6.Enabled = false;
            this.matrix6.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix6.ForeColor = System.Drawing.Color.Black;
            this.matrix6.Location = new System.Drawing.Point(157, 371);
            this.matrix6.Name = "matrix6";
            this.matrix6.Size = new System.Drawing.Size(64, 58);
            this.matrix6.TabIndex = 60;
            this.matrix6.Text = "6";
            this.matrix6.UseVisualStyleBackColor = false;
            // 
            // matrix7
            // 
            this.matrix7.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix7.Enabled = false;
            this.matrix7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SpringGreen;
            this.matrix7.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix7.ForeColor = System.Drawing.Color.Black;
            this.matrix7.Location = new System.Drawing.Point(29, 429);
            this.matrix7.Name = "matrix7";
            this.matrix7.Size = new System.Drawing.Size(64, 58);
            this.matrix7.TabIndex = 70;
            this.matrix7.Text = "7";
            this.matrix7.UseVisualStyleBackColor = false;
            // 
            // matrix8
            // 
            this.matrix8.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix8.Enabled = false;
            this.matrix8.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix8.ForeColor = System.Drawing.Color.Black;
            this.matrix8.Location = new System.Drawing.Point(93, 429);
            this.matrix8.Name = "matrix8";
            this.matrix8.Size = new System.Drawing.Size(64, 58);
            this.matrix8.TabIndex = 80;
            this.matrix8.Text = "8";
            this.matrix8.UseVisualStyleBackColor = false;
            // 
            // matrix9
            // 
            this.matrix9.BackColor = System.Drawing.Color.SpringGreen;
            this.matrix9.Enabled = false;
            this.matrix9.Font = new System.Drawing.Font("Immortal", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.matrix9.ForeColor = System.Drawing.Color.Black;
            this.matrix9.Location = new System.Drawing.Point(157, 429);
            this.matrix9.Name = "matrix9";
            this.matrix9.Size = new System.Drawing.Size(64, 58);
            this.matrix9.TabIndex = 90;
            this.matrix9.Text = "9";
            this.matrix9.UseVisualStyleBackColor = false;
            // 
            // labelApresentacao
            // 
            this.labelApresentacao.AutoSize = true;
            this.labelApresentacao.BackColor = System.Drawing.Color.Black;
            this.labelApresentacao.Font = new System.Drawing.Font("Immortal", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelApresentacao.ForeColor = System.Drawing.Color.Silver;
            this.labelApresentacao.Location = new System.Drawing.Point(18, 522);
            this.labelApresentacao.Name = "labelApresentacao";
            this.labelApresentacao.Size = new System.Drawing.Size(569, 17);
            this.labelApresentacao.TabIndex = 101;
            this.labelApresentacao.Text = "Desenvolvido por Alberto JPS, Antônio e Gabriel Coelho - Turma C# Manhã";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 545);
            this.Controls.Add(this.labelApresentacao);
            this.Controls.Add(this.matrix9);
            this.Controls.Add(this.matrix8);
            this.Controls.Add(this.matrix7);
            this.Controls.Add(this.matrix6);
            this.Controls.Add(this.matrix5);
            this.Controls.Add(this.matrix4);
            this.Controls.Add(this.matrix2);
            this.Controls.Add(this.matrix3);
            this.Controls.Add(this.matrix1);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonResetar);
            this.Controls.Add(this.buttonIniciar);
            this.Controls.Add(this.textBoxPalavra);
            this.Controls.Add(this.labelPalavra);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("FFF Tusj", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.SpringGreen;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelPalavra;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonResetar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button matrix1;
        private System.Windows.Forms.Button matrix3;
        private System.Windows.Forms.Button matrix2;
        private System.Windows.Forms.Button matrix4;
        private System.Windows.Forms.Button matrix5;
        private System.Windows.Forms.Button matrix6;
        private System.Windows.Forms.Button matrix7;
        private System.Windows.Forms.Button matrix8;
        private System.Windows.Forms.Button matrix9;
        private System.Windows.Forms.TextBox textBoxPalavra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rodada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Palavra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pontos;
        private System.Windows.Forms.Label labelApresentacao;
    }
}

