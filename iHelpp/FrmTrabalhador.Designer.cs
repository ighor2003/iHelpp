using System;

namespace iHelpp
{
    partial class FrmTrabalhador
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaTrabalhador = new System.Windows.Forms.TextBox();
            this.txtEmailTrabalhador = new System.Windows.Forms.TextBox();
            this.txtNameTrabalhador = new System.Windows.Forms.TextBox();
            this.listBoxTrabalhador = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.bntConsultar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCepTrabalhador = new System.Windows.Forms.TextBox();
            this.txtCpfTrabalhador = new System.Windows.Forms.TextBox();
            this.txtCelularTrabalhador = new System.Windows.Forms.TextBox();
            this.txtTelefoneTrabalhador = new System.Windows.Forms.TextBox();
            this.btnLimparTrab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(406, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(47, 22);
            this.txtId.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nome:";
            // 
            // txtSenhaTrabalhador
            // 
            this.txtSenhaTrabalhador.Location = new System.Drawing.Point(274, 94);
            this.txtSenhaTrabalhador.Name = "txtSenhaTrabalhador";
            this.txtSenhaTrabalhador.Size = new System.Drawing.Size(119, 22);
            this.txtSenhaTrabalhador.TabIndex = 34;
            // 
            // txtEmailTrabalhador
            // 
            this.txtEmailTrabalhador.Location = new System.Drawing.Point(274, 66);
            this.txtEmailTrabalhador.Name = "txtEmailTrabalhador";
            this.txtEmailTrabalhador.Size = new System.Drawing.Size(119, 22);
            this.txtEmailTrabalhador.TabIndex = 33;
            // 
            // txtNameTrabalhador
            // 
            this.txtNameTrabalhador.Location = new System.Drawing.Point(274, 38);
            this.txtNameTrabalhador.Name = "txtNameTrabalhador";
            this.txtNameTrabalhador.Size = new System.Drawing.Size(119, 22);
            this.txtNameTrabalhador.TabIndex = 32;
            // 
            // listBoxTrabalhador
            // 
            this.listBoxTrabalhador.FormattingEnabled = true;
            this.listBoxTrabalhador.ItemHeight = 16;
            this.listBoxTrabalhador.Location = new System.Drawing.Point(563, 108);
            this.listBoxTrabalhador.Name = "listBoxTrabalhador";
            this.listBoxTrabalhador.Size = new System.Drawing.Size(236, 196);
            this.listBoxTrabalhador.TabIndex = 31;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(767, 408);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(93, 31);
            this.btnFechar.TabIndex = 30;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click_1);
            // 
            // bntConsultar
            // 
            this.bntConsultar.Location = new System.Drawing.Point(257, 343);
            this.bntConsultar.Name = "bntConsultar";
            this.bntConsultar.Size = new System.Drawing.Size(93, 37);
            this.bntConsultar.TabIndex = 28;
            this.bntConsultar.Text = "Consultar";
            this.bntConsultar.UseVisualStyleBackColor = true;
            this.bntConsultar.Click += new System.EventHandler(this.bntConsultar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(306, 300);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(93, 37);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(207, 300);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(93, 37);
            this.btnInserir.TabIndex = 26;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "CEP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Celular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Telefone";
            // 
            // txtCepTrabalhador
            // 
            this.txtCepTrabalhador.Location = new System.Drawing.Point(274, 122);
            this.txtCepTrabalhador.Name = "txtCepTrabalhador";
            this.txtCepTrabalhador.Size = new System.Drawing.Size(119, 22);
            this.txtCepTrabalhador.TabIndex = 45;
            // 
            // txtCpfTrabalhador
            // 
            this.txtCpfTrabalhador.Location = new System.Drawing.Point(274, 150);
            this.txtCpfTrabalhador.Name = "txtCpfTrabalhador";
            this.txtCpfTrabalhador.Size = new System.Drawing.Size(119, 22);
            this.txtCpfTrabalhador.TabIndex = 46;
            // 
            // txtCelularTrabalhador
            // 
            this.txtCelularTrabalhador.Location = new System.Drawing.Point(274, 178);
            this.txtCelularTrabalhador.Name = "txtCelularTrabalhador";
            this.txtCelularTrabalhador.Size = new System.Drawing.Size(119, 22);
            this.txtCelularTrabalhador.TabIndex = 47;
            // 
            // txtTelefoneTrabalhador
            // 
            this.txtTelefoneTrabalhador.Location = new System.Drawing.Point(274, 206);
            this.txtTelefoneTrabalhador.Name = "txtTelefoneTrabalhador";
            this.txtTelefoneTrabalhador.Size = new System.Drawing.Size(119, 22);
            this.txtTelefoneTrabalhador.TabIndex = 48;
            // 
            // btnLimparTrab
            // 
            this.btnLimparTrab.Location = new System.Drawing.Point(563, 408);
            this.btnLimparTrab.Name = "btnLimparTrab";
            this.btnLimparTrab.Size = new System.Drawing.Size(75, 23);
            this.btnLimparTrab.TabIndex = 49;
            this.btnLimparTrab.Text = "Limpar";
            this.btnLimparTrab.UseVisualStyleBackColor = true;
            this.btnLimparTrab.Click += new System.EventHandler(this.btnLimparTrab_Click);
            // 
            // FrmTrabalhador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLimparTrab);
            this.Controls.Add(this.txtTelefoneTrabalhador);
            this.Controls.Add(this.txtCelularTrabalhador);
            this.Controls.Add(this.txtCpfTrabalhador);
            this.Controls.Add(this.txtCepTrabalhador);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenhaTrabalhador);
            this.Controls.Add(this.txtEmailTrabalhador);
            this.Controls.Add(this.txtNameTrabalhador);
            this.Controls.Add(this.listBoxTrabalhador);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.bntConsultar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTrabalhador";
            this.Text = "FrmTrabalhador";
            this.Load += new System.EventHandler(this.FrmTrabalhador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaTrabalhador;
        private System.Windows.Forms.TextBox txtEmailTrabalhador;
        private System.Windows.Forms.TextBox txtNameTrabalhador;
        private System.Windows.Forms.ListBox listBoxTrabalhador;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button bntConsultar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCepTrabalhador;
        private System.Windows.Forms.TextBox txtCpfTrabalhador;
        private System.Windows.Forms.TextBox txtCelularTrabalhador;
        private System.Windows.Forms.TextBox txtTelefoneTrabalhador;
        private System.Windows.Forms.Button btnLimparTrab;
    }
}