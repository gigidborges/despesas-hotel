namespace Exer015
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblDia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.grbQuarto = new System.Windows.Forms.GroupBox();
            this.radDuplo = new System.Windows.Forms.RadioButton();
            this.radSimple = new System.Windows.Forms.RadioButton();
            this.grbServico = new System.Windows.Forms.GroupBox();
            this.c4 = new System.Windows.Forms.CheckBox();
            this.c2 = new System.Windows.Forms.CheckBox();
            this.c3 = new System.Windows.Forms.CheckBox();
            this.c1 = new System.Windows.Forms.CheckBox();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.masSaida = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.masEntrada = new System.Windows.Forms.MaskedTextBox();
            this.grbPagamento = new System.Windows.Forms.GroupBox();
            this.radParcelado = new System.Windows.Forms.RadioButton();
            this.radVista = new System.Windows.Forms.RadioButton();
            this.grbTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDesconto = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblServico = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDiaria = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grbQuarto.SuspendLayout();
            this.grbServico.SuspendLayout();
            this.grbData.SuspendLayout();
            this.grbPagamento.SuspendLayout();
            this.grbTotal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.BackColor = System.Drawing.Color.Orange;
            this.lblDia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(12, 24);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(138, 38);
            this.lblDia.TabIndex = 0;
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Orange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Moscabessa- Fechamento de Conta Checkout\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHora
            // 
            this.LblHora.BackColor = System.Drawing.Color.Orange;
            this.LblHora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.Location = new System.Drawing.Point(808, 24);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(144, 38);
            this.LblHora.TabIndex = 2;
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblHora.Click += new System.EventHandler(this.Label2_Click);
            // 
            // grbQuarto
            // 
            this.grbQuarto.BackColor = System.Drawing.Color.LightCoral;
            this.grbQuarto.Controls.Add(this.radDuplo);
            this.grbQuarto.Controls.Add(this.radSimple);
            this.grbQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbQuarto.Location = new System.Drawing.Point(12, 100);
            this.grbQuarto.Name = "grbQuarto";
            this.grbQuarto.Size = new System.Drawing.Size(276, 118);
            this.grbQuarto.TabIndex = 3;
            this.grbQuarto.TabStop = false;
            this.grbQuarto.Text = "Tipo de Quarto";
            // 
            // radDuplo
            // 
            this.radDuplo.AutoSize = true;
            this.radDuplo.Location = new System.Drawing.Point(20, 78);
            this.radDuplo.Name = "radDuplo";
            this.radDuplo.Size = new System.Drawing.Size(143, 24);
            this.radDuplo.TabIndex = 1;
            this.radDuplo.TabStop = true;
            this.radDuplo.Text = "Duplo R$280,00";
            this.radDuplo.UseVisualStyleBackColor = true;
            // 
            // radSimple
            // 
            this.radSimple.AutoSize = true;
            this.radSimple.Location = new System.Drawing.Point(20, 34);
            this.radSimple.Name = "radSimple";
            this.radSimple.Size = new System.Drawing.Size(157, 24);
            this.radSimple.TabIndex = 0;
            this.radSimple.TabStop = true;
            this.radSimple.Text = "Simples R$150,00";
            this.radSimple.UseVisualStyleBackColor = true;
            // 
            // grbServico
            // 
            this.grbServico.BackColor = System.Drawing.Color.LightCoral;
            this.grbServico.Controls.Add(this.c4);
            this.grbServico.Controls.Add(this.c2);
            this.grbServico.Controls.Add(this.c3);
            this.grbServico.Controls.Add(this.c1);
            this.grbServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbServico.Location = new System.Drawing.Point(303, 100);
            this.grbServico.Name = "grbServico";
            this.grbServico.Size = new System.Drawing.Size(418, 118);
            this.grbServico.TabIndex = 4;
            this.grbServico.TabStop = false;
            this.grbServico.Text = "Serviços Utilizados";
            // 
            // c4
            // 
            this.c4.AutoSize = true;
            this.c4.Location = new System.Drawing.Point(227, 79);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(172, 24);
            this.c4.TabIndex = 3;
            this.c4.Text = "Serviço 4 -R$200,00";
            this.c4.UseVisualStyleBackColor = true;
            // 
            // c2
            // 
            this.c2.AutoSize = true;
            this.c2.Location = new System.Drawing.Point(32, 79);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(163, 24);
            this.c2.TabIndex = 2;
            this.c2.Text = "Serviço 2 -R$80,00";
            this.c2.UseVisualStyleBackColor = true;
            // 
            // c3
            // 
            this.c3.AutoSize = true;
            this.c3.Location = new System.Drawing.Point(227, 40);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(172, 24);
            this.c3.TabIndex = 1;
            this.c3.Text = "Serviço 3 -R$120,00";
            this.c3.UseVisualStyleBackColor = true;
            // 
            // c1
            // 
            this.c1.AutoSize = true;
            this.c1.Location = new System.Drawing.Point(32, 40);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(163, 24);
            this.c1.TabIndex = 0;
            this.c1.Text = "Serviço 1 -R$50,00";
            this.c1.UseVisualStyleBackColor = true;
            // 
            // grbData
            // 
            this.grbData.BackColor = System.Drawing.Color.LightCoral;
            this.grbData.Controls.Add(this.masSaida);
            this.grbData.Controls.Add(this.label3);
            this.grbData.Controls.Add(this.label2);
            this.grbData.Controls.Add(this.masEntrada);
            this.grbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.Location = new System.Drawing.Point(739, 100);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(213, 118);
            this.grbData.TabIndex = 4;
            this.grbData.TabStop = false;
            this.grbData.Text = "Data:";
            // 
            // masSaida
            // 
            this.masSaida.Location = new System.Drawing.Point(86, 77);
            this.masSaida.Mask = "00/00/0000";
            this.masSaida.Name = "masSaida";
            this.masSaida.Size = new System.Drawing.Size(121, 26);
            this.masSaida.TabIndex = 3;
            this.masSaida.ValidatingType = typeof(System.DateTime);
            this.masSaida.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MasSaida_MaskInputRejected);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrada:";
            // 
            // masEntrada
            // 
            this.masEntrada.Location = new System.Drawing.Point(86, 34);
            this.masEntrada.Mask = "00/00/0000";
            this.masEntrada.Name = "masEntrada";
            this.masEntrada.Size = new System.Drawing.Size(121, 26);
            this.masEntrada.TabIndex = 0;
            this.masEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // grbPagamento
            // 
            this.grbPagamento.BackColor = System.Drawing.Color.LightCoral;
            this.grbPagamento.Controls.Add(this.radParcelado);
            this.grbPagamento.Controls.Add(this.radVista);
            this.grbPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPagamento.Location = new System.Drawing.Point(12, 241);
            this.grbPagamento.Name = "grbPagamento";
            this.grbPagamento.Size = new System.Drawing.Size(427, 80);
            this.grbPagamento.TabIndex = 4;
            this.grbPagamento.TabStop = false;
            this.grbPagamento.Text = "Forma de Pagamento:";
            // 
            // radParcelado
            // 
            this.radParcelado.AutoSize = true;
            this.radParcelado.Location = new System.Drawing.Point(247, 39);
            this.radParcelado.Name = "radParcelado";
            this.radParcelado.Size = new System.Drawing.Size(98, 24);
            this.radParcelado.TabIndex = 1;
            this.radParcelado.TabStop = true;
            this.radParcelado.Text = "Parcelado";
            this.radParcelado.UseVisualStyleBackColor = true;
            // 
            // radVista
            // 
            this.radVista.AutoSize = true;
            this.radVista.Location = new System.Drawing.Point(20, 39);
            this.radVista.Name = "radVista";
            this.radVista.Size = new System.Drawing.Size(207, 24);
            this.radVista.TabIndex = 0;
            this.radVista.TabStop = true;
            this.radVista.Text = "A VISTA - 10% Desconto";
            this.radVista.UseVisualStyleBackColor = true;
            // 
            // grbTotal
            // 
            this.grbTotal.BackColor = System.Drawing.Color.LightCoral;
            this.grbTotal.Controls.Add(this.lblTotal);
            this.grbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTotal.Location = new System.Drawing.Point(660, 241);
            this.grbTotal.Name = "grbTotal";
            this.grbTotal.Size = new System.Drawing.Size(292, 80);
            this.grbTotal.TabIndex = 5;
            this.grbTotal.TabStop = false;
            this.grbTotal.Text = "Total de Dias Hospedados";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(33, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(122, 37);
            this.lblTotal.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightYellow;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(474, 254);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(154, 67);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Controls.Add(this.lblTotal2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblSub);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblDesconto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblServico);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDiaria);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(939, 176);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULTADOS:";
            // 
            // lblTotal2
            // 
            this.lblTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal2.Location = new System.Drawing.Point(541, 117);
            this.lblTotal2.Name = "lblTotal2";
            this.lblTotal2.Size = new System.Drawing.Size(154, 31);
            this.lblTotal2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "TOTAL A PAGAR";
            // 
            // lblSub
            // 
            this.lblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSub.Location = new System.Drawing.Point(795, 35);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(133, 31);
            this.lblSub.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(712, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sub Total";
            // 
            // lblDesconto
            // 
            this.lblDesconto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDesconto.Location = new System.Drawing.Point(506, 45);
            this.lblDesconto.Name = "lblDesconto";
            this.lblDesconto.Size = new System.Drawing.Size(154, 31);
            this.lblDesconto.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Desconto";
            // 
            // lblServico
            // 
            this.lblServico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblServico.Location = new System.Drawing.Point(190, 118);
            this.lblServico.Name = "lblServico";
            this.lblServico.Size = new System.Drawing.Size(154, 31);
            this.lblServico.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tota Serviços";
            // 
            // lblDiaria
            // 
            this.lblDiaria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiaria.Location = new System.Drawing.Point(190, 45);
            this.lblDiaria.Name = "lblDiaria";
            this.lblDiaria.Size = new System.Drawing.Size(154, 31);
            this.lblDiaria.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor das Diárias";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.LightYellow;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(203, 545);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(154, 52);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.LightYellow;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(548, 545);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(154, 52);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(964, 628);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grbTotal);
            this.Controls.Add(this.grbPagamento);
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.grbServico);
            this.Controls.Add(this.grbQuarto);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDia);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbQuarto.ResumeLayout(false);
            this.grbQuarto.PerformLayout();
            this.grbServico.ResumeLayout(false);
            this.grbServico.PerformLayout();
            this.grbData.ResumeLayout(false);
            this.grbData.PerformLayout();
            this.grbPagamento.ResumeLayout(false);
            this.grbPagamento.PerformLayout();
            this.grbTotal.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.GroupBox grbQuarto;
        private System.Windows.Forms.RadioButton radDuplo;
        private System.Windows.Forms.RadioButton radSimple;
        private System.Windows.Forms.GroupBox grbServico;
        private System.Windows.Forms.CheckBox c4;
        private System.Windows.Forms.CheckBox c2;
        private System.Windows.Forms.CheckBox c3;
        private System.Windows.Forms.CheckBox c1;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.MaskedTextBox masSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox masEntrada;
        private System.Windows.Forms.GroupBox grbPagamento;
        private System.Windows.Forms.RadioButton radParcelado;
        private System.Windows.Forms.RadioButton radVista;
        private System.Windows.Forms.GroupBox grbTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDesconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblServico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDiaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer timer1;
    }
}

