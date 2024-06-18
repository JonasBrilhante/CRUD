namespace Grid
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
            components = new System.ComponentModel.Container();
            tb_nome = new TextBox();
            tb_email = new TextBox();
            tb_senha = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grid = new DataGridView();
            timer = new System.Windows.Forms.Timer(components);
            lb_timer = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(670, 41);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(399, 31);
            tb_nome.TabIndex = 0;
            // 
            // tb_email
            // 
            tb_email.Location = new Point(670, 103);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(399, 31);
            tb_email.TabIndex = 1;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(670, 167);
            tb_senha.Name = "tb_senha";
            tb_senha.Size = new Size(150, 31);
            tb_senha.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(957, 164);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Atualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(957, 404);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Exibir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(813, 404);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Recarregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(670, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 6;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(670, 75);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(670, 137);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            // 
            // grid
            // 
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(12, 12);
            grid.Name = "grid";
            grid.RowHeadersWidth = 62;
            grid.Size = new Size(625, 386);
            grid.TabIndex = 9;
            grid.CellClick += grid_CellClick;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // lb_timer
            // 
            lb_timer.AutoSize = true;
            lb_timer.Location = new Point(36, 416);
            lb_timer.Name = "lb_timer";
            lb_timer.Size = new Size(0, 25);
            lb_timer.TabIndex = 10;
            // 
            // button4
            // 
            button4.Location = new Point(670, 404);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 11;
            button4.Text = "Cadastrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 450);
            Controls.Add(button4);
            Controls.Add(lb_timer);
            Controls.Add(grid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tb_senha);
            Controls.Add(tb_email);
            Controls.Add(tb_nome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_nome;
        private TextBox tb_email;
        private TextBox tb_senha;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView grid;
        private System.Windows.Forms.Timer timer;
        private Label lb_timer;
        private Button button4;
    }
}
