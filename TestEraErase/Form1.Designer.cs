namespace TestEraErase
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.lstNormal = new System.Windows.Forms.ListBox();
			this.btnErase = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblNormal = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lstTarget = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblTarget = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstNormal
			// 
			this.lstNormal.FormattingEnabled = true;
			this.lstNormal.Location = new System.Drawing.Point(9, 62);
			this.lstNormal.Name = "lstNormal";
			this.lstNormal.Size = new System.Drawing.Size(272, 69);
			this.lstNormal.TabIndex = 0;
			// 
			// btnErase
			// 
			this.btnErase.BackColor = System.Drawing.Color.Red;
			this.btnErase.Enabled = false;
			this.btnErase.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnErase.ForeColor = System.Drawing.Color.White;
			this.btnErase.Location = new System.Drawing.Point(415, 239);
			this.btnErase.Name = "btnErase";
			this.btnErase.Size = new System.Drawing.Size(167, 59);
			this.btnErase.TabIndex = 3;
			this.btnErase.Text = "不要と思われる定義のみをレジストリから\r\n取り除く";
			this.btnErase.UseVisualStyleBackColor = false;
			this.btnErase.Visible = false;
			this.btnErase.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(12, 189);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(272, 109);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "終了";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblNormal
			// 
			this.lblNormal.Location = new System.Drawing.Point(9, 146);
			this.lblNormal.Name = "lblNormal";
			this.lblNormal.Size = new System.Drawing.Size(292, 40);
			this.lblNormal.TabIndex = 1;
			this.lblNormal.Text = "テスト用元号設定は見つかりませんでした。";
			this.lblNormal.UseMnemonic = false;
			this.lblNormal.Visible = false;
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(557, 13);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Nls\\Calendars\\Japanese\\Eras";
			this.textBox1.WordWrap = false;
			// 
			// lstTarget
			// 
			this.lstTarget.FormattingEnabled = true;
			this.lstTarget.Location = new System.Drawing.Point(310, 62);
			this.lstTarget.Name = "lstTarget";
			this.lstTarget.Size = new System.Drawing.Size(272, 69);
			this.lstTarget.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "削除非対象";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(307, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "削除対象";
			// 
			// lblTarget
			// 
			this.lblTarget.Location = new System.Drawing.Point(307, 146);
			this.lblTarget.Name = "lblTarget";
			this.lblTarget.Size = new System.Drawing.Size(275, 40);
			this.lblTarget.TabIndex = 8;
			this.lblTarget.Text = "テスト用元号設定が見つかりました。";
			this.lblTarget.UseMnemonic = false;
			this.lblTarget.Visible = false;
			// 
			// Form1
			// 
			this.AcceptButton = this.btnCancel;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(593, 309);
			this.Controls.Add(this.lblTarget);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstTarget);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.lblNormal);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnErase);
			this.Controls.Add(this.lstNormal);
			this.Font = new System.Drawing.Font("ＭＳ ゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TestEraErase V1.0";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstNormal;
		private System.Windows.Forms.Button btnErase;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblNormal;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox lstTarget;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTarget;
	}
}

