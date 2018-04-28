using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace TestEraErase
{
	public partial class Form1 : Form
	{
		private const string baseKeyName = @"SYSTEM\CurrentControlSet\Control\Nls\Calendars\Japanese\Eras";

		private List<string> targetValueName = new List<string>();

		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (this.DesignMode) {
				return;
			}

			using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(baseKeyName)) {
				foreach (string valueName in regKey.GetValueNames()) {
					bool target = false;
					string valueString = "";
					try {
						object val = regKey.GetValue(valueName);
						if (val != null) {
							valueString = val.ToString();
							if (string.CompareOrdinal(valueString, "？？_？_??????_?") == 0) {
								this.targetValueName.Add(valueName);
								target = true;
							}
						} else {
							valueString = "[null]";
						}
					} catch (Exception ex) {
						valueString = ex.ToString();
					}

					if (target) {
						this.lstTarget.Items.Add(string.Format("{0}:{1}", valueName, valueString));
					} else {
						this.lstNormal.Items.Add(string.Format("{0}:{1}", valueName, valueString));
					}
				}

				regKey.Close();
			}

			if (this.targetValueName.Count == 0) {
				this.lblNormal.Visible = true;
			} else {
				this.btnErase.Visible =
				this.btnErase.Enabled = true;
				this.lblTarget.Visible = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "テスト用元号設定をレジストリから削除します。\r\n問題が発生した場合は自己の責任において解決してください。\r\n削除を実行しますか？", "レジストリ操作の確認",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) {
				MessageBox.Show(this, "キャンセルしました", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			this.btnErase.Enabled = false;

			using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(baseKeyName, true)) {
				foreach (string valueName in this.targetValueName) {
					regKey.DeleteValue(valueName);
				}

				regKey.Close();
			}

			MessageBox.Show(this, "削除しました", "お知らせ", MessageBoxButtons.OK, MessageBoxIcon.Information);

			this.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
