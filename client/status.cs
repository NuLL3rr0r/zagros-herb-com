using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using AOSMTPLib;

namespace herbal.e.news.prog
{
	/// <summary>
	/// Summary description for status.
	/// </summary>
	public class frm_status : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader clmnhdr_Recipient;
		private System.Windows.Forms.ColumnHeader clmnhdr_Status;
		private System.Windows.Forms.ListView lsvRcpts;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Button btn_down;
		internal bool all_of_them;
		internal string subject;
		internal string body;
		internal string[] attachment = new string[100];
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frm_status()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_status));
			this.lsvRcpts = new System.Windows.Forms.ListView();
			this.clmnhdr_Recipient = new System.Windows.Forms.ColumnHeader();
			this.clmnhdr_Status = new System.Windows.Forms.ColumnHeader();
			this.lbl_status = new System.Windows.Forms.Label();
			this.btn_down = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lsvRcpts
			// 
			this.lsvRcpts.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.lsvRcpts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					   this.clmnhdr_Recipient,
																					   this.clmnhdr_Status});
			this.lsvRcpts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.lsvRcpts.FullRowSelect = true;
			this.lsvRcpts.GridLines = true;
			this.lsvRcpts.Location = new System.Drawing.Point(8, 48);
			this.lsvRcpts.Name = "lsvRcpts";
			this.lsvRcpts.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lsvRcpts.Size = new System.Drawing.Size(524, 308);
			this.lsvRcpts.TabIndex = 1;
			this.lsvRcpts.View = System.Windows.Forms.View.Details;
			// 
			// clmnhdr_Recipient
			// 
			this.clmnhdr_Recipient.Text = "Recipient";
			this.clmnhdr_Recipient.Width = 377;
			// 
			// clmnhdr_Status
			// 
			this.clmnhdr_Status.Text = "Status";
			this.clmnhdr_Status.Width = 143;
			// 
			// lbl_status
			// 
			this.lbl_status.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.lbl_status.ForeColor = System.Drawing.Color.Blue;
			this.lbl_status.Location = new System.Drawing.Point(56, 16);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_status.Size = new System.Drawing.Size(472, 23);
			this.lbl_status.TabIndex = 0;
			this.lbl_status.Text = "در حال دريافت ليست كاربران از وب سايت...";
			// 
			// btn_down
			// 
			this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_down.ForeColor = System.Drawing.Color.Transparent;
			this.btn_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_down.Image")));
			this.btn_down.Location = new System.Drawing.Point(8, 8);
			this.btn_down.Name = "btn_down";
			this.btn_down.Size = new System.Drawing.Size(40, 32);
			this.btn_down.TabIndex = 2;
			this.btn_down.Visible = false;
			this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
			// 
			// frm_status
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
			this.ClientSize = new System.Drawing.Size(540, 364);
			this.ControlBox = false;
			this.Controls.Add(this.btn_down);
			this.Controls.Add(this.lsvRcpts);
			this.Controls.Add(this.lbl_status);
			this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.ForeColor = System.Drawing.Color.Blue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_status";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "وضعيت ارسال... - موسسه گياهان داروئي زاگرس";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.frm_status_Load);
			this.Activated += new System.EventHandler(this.frm_status_Activated);
			this.ResumeLayout(false);

		}
		#endregion

		bool loaded = false;
		private MailClass oSmtp = new MailClass();

		public bool send_mail(string name, string to)
		{
			oSmtp.ClearRecipient();
			oSmtp.AddRecipient(name, to, 0);
			try
			{
				if(oSmtp.SendMail() == 0)
					return true;
				else
					return false;
			}
			catch
			{
				return false;
			}
		}

		private void btn_down_Click(object sender, System.EventArgs e)
		{
			this.Hide();
		}

		private void frm_status_Activated(object sender, System.EventArgs e)
		{
			if (loaded == true)
			{
				zagros_srv.zagros srv = new zagros_srv.zagros();
				DataSet ds = new DataSet();

				oSmtp.Reset();

				//oSmtp.Asynchronous = 1;
				oSmtp.ServerAddr = "";
				oSmtp.UserName = "";
				oSmtp.Password = "";
				oSmtp.Charset = "utf-8";
				oSmtp.CodePage = 65001;
				oSmtp.BodyFormat = 1;

				oSmtp.From = "zagros-herb.com";
				oSmtp.Subject = subject;
				oSmtp.BodyText = body;

				int counter = 0;
				while (attachment[counter] != null)
				{
					oSmtp.AddAttachment(attachment[counter]);
					counter++;
				}

				try
				{
					ds = srv.users_list();
					try
					{
						lbl_status.Text = "در حال ارسال اسناد...";

						counter = 0;
						foreach (DataRow dr in ds.Tables["users"].Rows)
						{
							if (Convert.ToBoolean(ds.Tables["users"].Rows[counter]["news"]) == true | all_of_them == true)
							{
								ListViewItem Item = lsvRcpts.Items.Add(ds.Tables["users"].Rows[counter]["E-Mail"].ToString().Trim());
								Item.SubItems.Add( "Ready..." );
							}
							counter++;
						}

						int count = lsvRcpts.Items.Count;

						for (counter = 0; counter < count; counter++)
						{
							lsvRcpts.Items[counter].SubItems[1].Text = "Queued...";
						}

						for (counter = 0; counter < count; counter++)
						{
							if (send_mail("", lsvRcpts.Items[counter].Text.Trim()))
								lsvRcpts.Items[counter].SubItems[1].Text = "Success...";
							else
								lsvRcpts.Items[counter].SubItems[1].Text = "Error...";
						}

						lbl_status.Text = "اتمام عمليات ارسال اسناد...";
					}
					catch
					{
						lbl_status.Text = "خطا در ارسال خبرنامه...";
					}
				}
				catch
				{
					lbl_status.Text = "امكان دسترسي به وب سايت برنامه وجود ندارد...";
				}
				btn_down.Visible = true;
				loaded = false;
			}
			btn_down.Select();
		}

		private void frm_status_Load(object sender, System.EventArgs e)
		{
			loaded = true;

			oSmtp.RegisterKey = "W6X4Y5YKY505X50505Y5Y5Y5K5G3Y3Y3Y3Y3Y3K3Y30F0303039";
			oSmtp.SSL_registerkey = "GHFGFGFGZGZGZGZEEEEEEEEEGEGEGEGFFFFFFFFZFZFZFZFZEZA";
		}
	}
}