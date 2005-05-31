using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace herbal.e.news.prog
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frm_news : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog ofd_attachment;
		private System.Windows.Forms.ContextMenu ctx_attachment;
		private System.Windows.Forms.MenuItem mnu_ClearAll;
		private System.Windows.Forms.MenuItem mnu_Clear;
		private System.Windows.Forms.TabControl tab_main;
		private System.Windows.Forms.TabPage tbp_message;
		private System.Windows.Forms.TabPage tbp_security;
		private System.Windows.Forms.Button btn_protect;
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Label lbl_subject;
		private System.Windows.Forms.Label lbl_body;
		private System.Windows.Forms.Button btn_attachment;
		private System.Windows.Forms.TextBox txt_subject;
		private System.Windows.Forms.TextBox txt_body;
		private System.Windows.Forms.ListBox lst_attachment;
		private System.Windows.Forms.TextBox txt_protect;
		private AxSHDocVw.AxWebBrowser web_connection;
		private System.Windows.Forms.TabPage tbp_users;
		private System.Windows.Forms.DataGrid dg_users;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_mail;
		private System.Windows.Forms.TextBox txt_news;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TextBox txt_license;
		private System.Windows.Forms.TextBox txt_address;
		private System.Windows.Forms.TextBox txt_family;
		private System.Windows.Forms.TextBox txt_job;
		private System.Windows.Forms.TextBox txt_sex;
		private System.Windows.Forms.TextBox txt_province;
		private System.Windows.Forms.TextBox txt_age;
		private System.Windows.Forms.TextBox txt_city;
		private System.Windows.Forms.TextBox txt_postalcode;
		private System.Windows.Forms.TextBox txt_tel;
		private System.Windows.Forms.TextBox txt_fax;
		private System.Windows.Forms.Label lbl_news;
		private System.Windows.Forms.Label lbl_fax;
		private System.Windows.Forms.Label lbl_tel;
		private System.Windows.Forms.Label lbl_postalcode;
		private System.Windows.Forms.Label lbl_address;
		private System.Windows.Forms.Label lbl_city;
		private System.Windows.Forms.Label lbl_province;
		private System.Windows.Forms.Label lbl_job;
		private System.Windows.Forms.Label lbl_license;
		private System.Windows.Forms.Label lbl_age;
		private System.Windows.Forms.Label lbl_sex;
		private System.Windows.Forms.Label lbl_family;
		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.Label lbl_mail;
		public System.Windows.Forms.CheckBox chk_all_of_them;
		private System.Windows.Forms.Timer tmr_advrs;
		private System.ComponentModel.IContainer components;

		public frm_news()
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
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frm_news));
			this.ctx_attachment = new System.Windows.Forms.ContextMenu();
			this.mnu_Clear = new System.Windows.Forms.MenuItem();
			this.mnu_ClearAll = new System.Windows.Forms.MenuItem();
			this.ofd_attachment = new System.Windows.Forms.OpenFileDialog();
			this.tab_main = new System.Windows.Forms.TabControl();
			this.tbp_message = new System.Windows.Forms.TabPage();
			this.txt_protect = new System.Windows.Forms.TextBox();
			this.lst_attachment = new System.Windows.Forms.ListBox();
			this.txt_body = new System.Windows.Forms.TextBox();
			this.txt_subject = new System.Windows.Forms.TextBox();
			this.btn_attachment = new System.Windows.Forms.Button();
			this.lbl_body = new System.Windows.Forms.Label();
			this.lbl_subject = new System.Windows.Forms.Label();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_send = new System.Windows.Forms.Button();
			this.chk_all_of_them = new System.Windows.Forms.CheckBox();
			this.tbp_users = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_age = new System.Windows.Forms.TextBox();
			this.txt_city = new System.Windows.Forms.TextBox();
			this.txt_fax = new System.Windows.Forms.TextBox();
			this.txt_sex = new System.Windows.Forms.TextBox();
			this.txt_province = new System.Windows.Forms.TextBox();
			this.txt_tel = new System.Windows.Forms.TextBox();
			this.txt_family = new System.Windows.Forms.TextBox();
			this.txt_job = new System.Windows.Forms.TextBox();
			this.txt_postalcode = new System.Windows.Forms.TextBox();
			this.txt_news = new System.Windows.Forms.TextBox();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.txt_mail = new System.Windows.Forms.TextBox();
			this.txt_license = new System.Windows.Forms.TextBox();
			this.txt_address = new System.Windows.Forms.TextBox();
			this.lbl_news = new System.Windows.Forms.Label();
			this.lbl_fax = new System.Windows.Forms.Label();
			this.lbl_tel = new System.Windows.Forms.Label();
			this.lbl_postalcode = new System.Windows.Forms.Label();
			this.lbl_address = new System.Windows.Forms.Label();
			this.lbl_city = new System.Windows.Forms.Label();
			this.lbl_province = new System.Windows.Forms.Label();
			this.lbl_job = new System.Windows.Forms.Label();
			this.lbl_license = new System.Windows.Forms.Label();
			this.lbl_age = new System.Windows.Forms.Label();
			this.lbl_sex = new System.Windows.Forms.Label();
			this.lbl_family = new System.Windows.Forms.Label();
			this.lbl_name = new System.Windows.Forms.Label();
			this.lbl_mail = new System.Windows.Forms.Label();
			this.dg_users = new System.Windows.Forms.DataGrid();
			this.tbp_security = new System.Windows.Forms.TabPage();
			this.web_connection = new AxSHDocVw.AxWebBrowser();
			this.btn_protect = new System.Windows.Forms.Button();
			this.tmr_advrs = new System.Windows.Forms.Timer(this.components);
			this.tab_main.SuspendLayout();
			this.tbp_message.SuspendLayout();
			this.tbp_users.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dg_users)).BeginInit();
			this.tbp_security.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.web_connection)).BeginInit();
			this.SuspendLayout();
			// 
			// ctx_attachment
			// 
			this.ctx_attachment.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.mnu_Clear,
																						   this.mnu_ClearAll});
			this.ctx_attachment.Popup += new System.EventHandler(this.ctx_attachment_Popup);
			// 
			// mnu_Clear
			// 
			this.mnu_Clear.Index = 0;
			this.mnu_Clear.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.mnu_Clear.Text = "Õ–›                                        Delete";
			this.mnu_Clear.Click += new System.EventHandler(this.mnu_Clear_Click);
			// 
			// mnu_ClearAll
			// 
			this.mnu_ClearAll.Index = 1;
			this.mnu_ClearAll.Shortcut = System.Windows.Forms.Shortcut.ShiftDel;
			this.mnu_ClearAll.Text = "Õ–›  „«„Ì ¬Ì „ Â«       Shift+Delete";
			this.mnu_ClearAll.Click += new System.EventHandler(this.mnu_ClearAll_Click);
			// 
			// ofd_attachment
			// 
			this.ofd_attachment.RestoreDirectory = true;
			// 
			// tab_main
			// 
			this.tab_main.Controls.Add(this.tbp_message);
			this.tab_main.Controls.Add(this.tbp_users);
			this.tab_main.Controls.Add(this.tbp_security);
			this.tab_main.Location = new System.Drawing.Point(0, 0);
			this.tab_main.Name = "tab_main";
			this.tab_main.SelectedIndex = 0;
			this.tab_main.Size = new System.Drawing.Size(422, 516);
			this.tab_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tab_main.TabIndex = 9;
			this.tab_main.SelectedIndexChanged += new System.EventHandler(this.tab_main_SelectedIndexChanged);
			// 
			// tbp_message
			// 
			this.tbp_message.Controls.Add(this.txt_protect);
			this.tbp_message.Controls.Add(this.lst_attachment);
			this.tbp_message.Controls.Add(this.txt_body);
			this.tbp_message.Controls.Add(this.txt_subject);
			this.tbp_message.Controls.Add(this.btn_attachment);
			this.tbp_message.Controls.Add(this.lbl_body);
			this.tbp_message.Controls.Add(this.lbl_subject);
			this.tbp_message.Controls.Add(this.btn_cancel);
			this.tbp_message.Controls.Add(this.btn_send);
			this.tbp_message.Controls.Add(this.chk_all_of_them);
			this.tbp_message.Location = new System.Drawing.Point(4, 27);
			this.tbp_message.Name = "tbp_message";
			this.tbp_message.Size = new System.Drawing.Size(414, 485);
			this.tbp_message.TabIndex = 0;
			this.tbp_message.Text = "«—”«· Å»«„";
			// 
			// txt_protect
			// 
			this.txt_protect.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_protect.Location = new System.Drawing.Point(224, 456);
			this.txt_protect.Name = "txt_protect";
			this.txt_protect.Size = new System.Drawing.Size(184, 21);
			this.txt_protect.TabIndex = 6;
			this.txt_protect.Text = "·ÿ›« —„“ ⁄»Ê— —« Ê«—œ ‰„«∆Ìœ...";
			this.txt_protect.Enter += new System.EventHandler(this.txt_protect_Enter);
			// 
			// lst_attachment
			// 
			this.lst_attachment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lst_attachment.ContextMenu = this.ctx_attachment;
			this.lst_attachment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lst_attachment.HorizontalScrollbar = true;
			this.lst_attachment.Location = new System.Drawing.Point(8, 296);
			this.lst_attachment.Name = "lst_attachment";
			this.lst_attachment.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lst_attachment.Size = new System.Drawing.Size(296, 119);
			this.lst_attachment.TabIndex = 4;
			// 
			// txt_body
			// 
			this.txt_body.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_body.Location = new System.Drawing.Point(8, 48);
			this.txt_body.Multiline = true;
			this.txt_body.Name = "txt_body";
			this.txt_body.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_body.Size = new System.Drawing.Size(296, 232);
			this.txt_body.TabIndex = 2;
			this.txt_body.Text = "";
			// 
			// txt_subject
			// 
			this.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_subject.Location = new System.Drawing.Point(8, 8);
			this.txt_subject.Name = "txt_subject";
			this.txt_subject.Size = new System.Drawing.Size(296, 26);
			this.txt_subject.TabIndex = 1;
			this.txt_subject.Text = "";
			// 
			// btn_attachment
			// 
			this.btn_attachment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_attachment.Image = ((System.Drawing.Image)(resources.GetObject("btn_attachment.Image")));
			this.btn_attachment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_attachment.Location = new System.Drawing.Point(312, 296);
			this.btn_attachment.Name = "btn_attachment";
			this.btn_attachment.Size = new System.Drawing.Size(96, 32);
			this.btn_attachment.TabIndex = 3;
			this.btn_attachment.Text = "÷„«∆„";
			this.btn_attachment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_attachment.Click += new System.EventHandler(this.btn_attachment_Click);
			// 
			// lbl_body
			// 
			this.lbl_body.Image = ((System.Drawing.Image)(resources.GetObject("lbl_body.Image")));
			this.lbl_body.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_body.Location = new System.Drawing.Point(312, 48);
			this.lbl_body.Name = "lbl_body";
			this.lbl_body.Size = new System.Drawing.Size(96, 32);
			this.lbl_body.TabIndex = 0;
			this.lbl_body.Text = "„ ‰ ÅÌ«„:";
			this.lbl_body.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_subject
			// 
			this.lbl_subject.Image = ((System.Drawing.Image)(resources.GetObject("lbl_subject.Image")));
			this.lbl_subject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_subject.Location = new System.Drawing.Point(312, 8);
			this.lbl_subject.Name = "lbl_subject";
			this.lbl_subject.Size = new System.Drawing.Size(96, 32);
			this.lbl_subject.TabIndex = 0;
			this.lbl_subject.Text = "⁄‰Ê«‰:";
			this.lbl_subject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_cancel
			// 
			this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
			this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_cancel.Location = new System.Drawing.Point(8, 448);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(96, 32);
			this.btn_cancel.TabIndex = 8;
			this.btn_cancel.Text = "·€Ê";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_send
			// 
			this.btn_send.Enabled = false;
			this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_send.Image = ((System.Drawing.Image)(resources.GetObject("btn_send.Image")));
			this.btn_send.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_send.Location = new System.Drawing.Point(104, 448);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(96, 32);
			this.btn_send.TabIndex = 7;
			this.btn_send.Text = "«—”«·";
			this.btn_send.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// chk_all_of_them
			// 
			this.chk_all_of_them.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.chk_all_of_them.Location = new System.Drawing.Point(200, 432);
			this.chk_all_of_them.Name = "chk_all_of_them";
			this.chk_all_of_them.Size = new System.Drawing.Size(208, 16);
			this.chk_all_of_them.TabIndex = 5;
			this.chk_all_of_them.Text = "«—”«· Œ»—‰«„Â »—«Ì  „«„ «⁄÷« Ê ﬂ«—»—«‰";
			// 
			// tbp_users
			// 
			this.tbp_users.Controls.Add(this.groupBox1);
			this.tbp_users.Controls.Add(this.dg_users);
			this.tbp_users.Location = new System.Drawing.Point(4, 27);
			this.tbp_users.Name = "tbp_users";
			this.tbp_users.Size = new System.Drawing.Size(414, 485);
			this.tbp_users.TabIndex = 2;
			this.tbp_users.Text = "«⁄÷«";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.txt_age);
			this.groupBox1.Controls.Add(this.txt_city);
			this.groupBox1.Controls.Add(this.txt_fax);
			this.groupBox1.Controls.Add(this.txt_sex);
			this.groupBox1.Controls.Add(this.txt_province);
			this.groupBox1.Controls.Add(this.txt_tel);
			this.groupBox1.Controls.Add(this.txt_family);
			this.groupBox1.Controls.Add(this.txt_job);
			this.groupBox1.Controls.Add(this.txt_postalcode);
			this.groupBox1.Controls.Add(this.txt_news);
			this.groupBox1.Controls.Add(this.txt_name);
			this.groupBox1.Controls.Add(this.txt_mail);
			this.groupBox1.Controls.Add(this.txt_license);
			this.groupBox1.Controls.Add(this.txt_address);
			this.groupBox1.Controls.Add(this.lbl_news);
			this.groupBox1.Controls.Add(this.lbl_fax);
			this.groupBox1.Controls.Add(this.lbl_tel);
			this.groupBox1.Controls.Add(this.lbl_postalcode);
			this.groupBox1.Controls.Add(this.lbl_address);
			this.groupBox1.Controls.Add(this.lbl_city);
			this.groupBox1.Controls.Add(this.lbl_province);
			this.groupBox1.Controls.Add(this.lbl_job);
			this.groupBox1.Controls.Add(this.lbl_license);
			this.groupBox1.Controls.Add(this.lbl_age);
			this.groupBox1.Controls.Add(this.lbl_sex);
			this.groupBox1.Controls.Add(this.lbl_family);
			this.groupBox1.Controls.Add(this.lbl_name);
			this.groupBox1.Controls.Add(this.lbl_mail);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 240);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(400, 240);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "„‘Œ’«  [ﬂ«—»— / ⁄÷Ê] „Ê—œ ‰Ÿ—";
			// 
			// txt_age
			// 
			this.txt_age.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_age.ForeColor = System.Drawing.Color.Yellow;
			this.txt_age.Location = new System.Drawing.Point(264, 208);
			this.txt_age.Name = "txt_age";
			this.txt_age.ReadOnly = true;
			this.txt_age.Size = new System.Drawing.Size(128, 21);
			this.txt_age.TabIndex = 7;
			this.txt_age.Text = "";
			// 
			// txt_city
			// 
			this.txt_city.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_city.ForeColor = System.Drawing.Color.Yellow;
			this.txt_city.Location = new System.Drawing.Point(136, 208);
			this.txt_city.Name = "txt_city";
			this.txt_city.ReadOnly = true;
			this.txt_city.Size = new System.Drawing.Size(128, 21);
			this.txt_city.TabIndex = 11;
			this.txt_city.Text = "";
			// 
			// txt_fax
			// 
			this.txt_fax.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_fax.ForeColor = System.Drawing.Color.Yellow;
			this.txt_fax.Location = new System.Drawing.Point(8, 208);
			this.txt_fax.Name = "txt_fax";
			this.txt_fax.ReadOnly = true;
			this.txt_fax.Size = new System.Drawing.Size(128, 21);
			this.txt_fax.TabIndex = 15;
			this.txt_fax.Text = "";
			// 
			// txt_sex
			// 
			this.txt_sex.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_sex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_sex.ForeColor = System.Drawing.Color.Yellow;
			this.txt_sex.Location = new System.Drawing.Point(264, 168);
			this.txt_sex.Name = "txt_sex";
			this.txt_sex.ReadOnly = true;
			this.txt_sex.Size = new System.Drawing.Size(128, 21);
			this.txt_sex.TabIndex = 6;
			this.txt_sex.Text = "";
			// 
			// txt_province
			// 
			this.txt_province.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_province.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_province.ForeColor = System.Drawing.Color.Yellow;
			this.txt_province.Location = new System.Drawing.Point(136, 168);
			this.txt_province.Name = "txt_province";
			this.txt_province.ReadOnly = true;
			this.txt_province.Size = new System.Drawing.Size(128, 21);
			this.txt_province.TabIndex = 10;
			this.txt_province.Text = "";
			// 
			// txt_tel
			// 
			this.txt_tel.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_tel.ForeColor = System.Drawing.Color.Yellow;
			this.txt_tel.Location = new System.Drawing.Point(8, 168);
			this.txt_tel.Name = "txt_tel";
			this.txt_tel.ReadOnly = true;
			this.txt_tel.Size = new System.Drawing.Size(128, 21);
			this.txt_tel.TabIndex = 14;
			this.txt_tel.Text = "";
			// 
			// txt_family
			// 
			this.txt_family.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_family.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_family.ForeColor = System.Drawing.Color.Yellow;
			this.txt_family.Location = new System.Drawing.Point(264, 128);
			this.txt_family.Name = "txt_family";
			this.txt_family.ReadOnly = true;
			this.txt_family.Size = new System.Drawing.Size(128, 21);
			this.txt_family.TabIndex = 5;
			this.txt_family.Text = "";
			// 
			// txt_job
			// 
			this.txt_job.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_job.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_job.ForeColor = System.Drawing.Color.Yellow;
			this.txt_job.Location = new System.Drawing.Point(136, 128);
			this.txt_job.Name = "txt_job";
			this.txt_job.ReadOnly = true;
			this.txt_job.Size = new System.Drawing.Size(128, 21);
			this.txt_job.TabIndex = 9;
			this.txt_job.Text = "";
			// 
			// txt_postalcode
			// 
			this.txt_postalcode.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_postalcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_postalcode.ForeColor = System.Drawing.Color.Yellow;
			this.txt_postalcode.Location = new System.Drawing.Point(8, 128);
			this.txt_postalcode.Name = "txt_postalcode";
			this.txt_postalcode.ReadOnly = true;
			this.txt_postalcode.Size = new System.Drawing.Size(128, 21);
			this.txt_postalcode.TabIndex = 13;
			this.txt_postalcode.Text = "";
			// 
			// txt_news
			// 
			this.txt_news.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_news.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_news.ForeColor = System.Drawing.Color.Yellow;
			this.txt_news.Location = new System.Drawing.Point(8, 48);
			this.txt_news.Name = "txt_news";
			this.txt_news.ReadOnly = true;
			this.txt_news.Size = new System.Drawing.Size(192, 21);
			this.txt_news.TabIndex = 3;
			this.txt_news.Text = "";
			// 
			// txt_name
			// 
			this.txt_name.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_name.ForeColor = System.Drawing.Color.Yellow;
			this.txt_name.Location = new System.Drawing.Point(264, 88);
			this.txt_name.Name = "txt_name";
			this.txt_name.ReadOnly = true;
			this.txt_name.Size = new System.Drawing.Size(128, 21);
			this.txt_name.TabIndex = 4;
			this.txt_name.Text = "";
			// 
			// txt_mail
			// 
			this.txt_mail.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_mail.ForeColor = System.Drawing.Color.Yellow;
			this.txt_mail.Location = new System.Drawing.Point(200, 48);
			this.txt_mail.Name = "txt_mail";
			this.txt_mail.ReadOnly = true;
			this.txt_mail.Size = new System.Drawing.Size(192, 20);
			this.txt_mail.TabIndex = 2;
			this.txt_mail.Text = "";
			// 
			// txt_license
			// 
			this.txt_license.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_license.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_license.ForeColor = System.Drawing.Color.Yellow;
			this.txt_license.Location = new System.Drawing.Point(136, 88);
			this.txt_license.Name = "txt_license";
			this.txt_license.ReadOnly = true;
			this.txt_license.Size = new System.Drawing.Size(128, 21);
			this.txt_license.TabIndex = 8;
			this.txt_license.Text = "";
			// 
			// txt_address
			// 
			this.txt_address.BackColor = System.Drawing.Color.CornflowerBlue;
			this.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_address.ForeColor = System.Drawing.Color.Yellow;
			this.txt_address.Location = new System.Drawing.Point(8, 88);
			this.txt_address.Name = "txt_address";
			this.txt_address.ReadOnly = true;
			this.txt_address.Size = new System.Drawing.Size(128, 21);
			this.txt_address.TabIndex = 12;
			this.txt_address.Text = "";
			// 
			// lbl_news
			// 
			this.lbl_news.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_news.Location = new System.Drawing.Point(88, 32);
			this.lbl_news.Name = "lbl_news";
			this.lbl_news.Size = new System.Drawing.Size(112, 23);
			this.lbl_news.TabIndex = 0;
			this.lbl_news.Text = "Ê÷⁄Ì  «—”«· Œ»—‰«„Â";
			// 
			// lbl_fax
			// 
			this.lbl_fax.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_fax.Location = new System.Drawing.Point(32, 192);
			this.lbl_fax.Name = "lbl_fax";
			this.lbl_fax.TabIndex = 0;
			this.lbl_fax.Text = "›«ﬂ”";
			// 
			// lbl_tel
			// 
			this.lbl_tel.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_tel.Location = new System.Drawing.Point(32, 152);
			this.lbl_tel.Name = "lbl_tel";
			this.lbl_tel.TabIndex = 0;
			this.lbl_tel.Text = " ·›‰";
			// 
			// lbl_postalcode
			// 
			this.lbl_postalcode.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_postalcode.Location = new System.Drawing.Point(32, 112);
			this.lbl_postalcode.Name = "lbl_postalcode";
			this.lbl_postalcode.TabIndex = 0;
			this.lbl_postalcode.Text = "ﬂœÅ” Ì";
			// 
			// lbl_address
			// 
			this.lbl_address.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_address.Location = new System.Drawing.Point(32, 72);
			this.lbl_address.Name = "lbl_address";
			this.lbl_address.TabIndex = 0;
			this.lbl_address.Text = "¬œ—”";
			// 
			// lbl_city
			// 
			this.lbl_city.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_city.Location = new System.Drawing.Point(160, 192);
			this.lbl_city.Name = "lbl_city";
			this.lbl_city.TabIndex = 0;
			this.lbl_city.Text = "‘Â—” «‰";
			// 
			// lbl_province
			// 
			this.lbl_province.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_province.Location = new System.Drawing.Point(160, 152);
			this.lbl_province.Name = "lbl_province";
			this.lbl_province.TabIndex = 0;
			this.lbl_province.Text = "«” «‰";
			// 
			// lbl_job
			// 
			this.lbl_job.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_job.Location = new System.Drawing.Point(160, 112);
			this.lbl_job.Name = "lbl_job";
			this.lbl_job.TabIndex = 0;
			this.lbl_job.Text = "‘€·";
			// 
			// lbl_license
			// 
			this.lbl_license.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_license.Location = new System.Drawing.Point(152, 72);
			this.lbl_license.Name = "lbl_license";
			this.lbl_license.Size = new System.Drawing.Size(112, 23);
			this.lbl_license.TabIndex = 0;
			this.lbl_license.Text = "„œ—ﬂ Ê —‘ Â  Õ’Ì·Ì";
			// 
			// lbl_age
			// 
			this.lbl_age.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_age.Location = new System.Drawing.Point(288, 192);
			this.lbl_age.Name = "lbl_age";
			this.lbl_age.TabIndex = 0;
			this.lbl_age.Text = "”‰";
			// 
			// lbl_sex
			// 
			this.lbl_sex.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_sex.Location = new System.Drawing.Point(288, 152);
			this.lbl_sex.Name = "lbl_sex";
			this.lbl_sex.TabIndex = 0;
			this.lbl_sex.Text = "Ã‰”Ì ";
			// 
			// lbl_family
			// 
			this.lbl_family.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_family.Location = new System.Drawing.Point(288, 112);
			this.lbl_family.Name = "lbl_family";
			this.lbl_family.TabIndex = 0;
			this.lbl_family.Text = "‰«„ Œ«‰Ê«œêÌ";
			// 
			// lbl_name
			// 
			this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_name.Location = new System.Drawing.Point(288, 72);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.TabIndex = 0;
			this.lbl_name.Text = "‰«„";
			// 
			// lbl_mail
			// 
			this.lbl_mail.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_mail.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.lbl_mail.Location = new System.Drawing.Point(288, 32);
			this.lbl_mail.Name = "lbl_mail";
			this.lbl_mail.TabIndex = 0;
			this.lbl_mail.Text = "Å”  «·ﬂ —Ê‰ÌﬂÌ";
			// 
			// dg_users
			// 
			this.dg_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.dg_users.CaptionText = "·Ì”  «⁄÷« Ê ﬂ«—»—«‰ Ê» ”«Ì  zagros-herb.com";
			this.dg_users.DataMember = "";
			this.dg_users.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dg_users.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dg_users.Location = new System.Drawing.Point(8, 8);
			this.dg_users.Name = "dg_users";
			this.dg_users.PreferredColumnWidth = 170;
			this.dg_users.ReadOnly = true;
			this.dg_users.Size = new System.Drawing.Size(400, 224);
			this.dg_users.TabIndex = 1;
			this.dg_users.CurrentCellChanged += new System.EventHandler(this.dg_users_CurrentCellChanged);
			// 
			// tbp_security
			// 
			this.tbp_security.Controls.Add(this.web_connection);
			this.tbp_security.Controls.Add(this.btn_protect);
			this.tbp_security.Location = new System.Drawing.Point(4, 27);
			this.tbp_security.Name = "tbp_security";
			this.tbp_security.Size = new System.Drawing.Size(414, 485);
			this.tbp_security.TabIndex = 1;
			this.tbp_security.Text = "«„‰Ì ";
			// 
			// web_connection
			// 
			this.web_connection.ContainingControl = this;
			this.web_connection.Enabled = true;
			this.web_connection.Location = new System.Drawing.Point(8, 48);
			this.web_connection.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("web_connection.OcxState")));
			this.web_connection.Size = new System.Drawing.Size(400, 432);
			this.web_connection.TabIndex = 10;
			// 
			// btn_protect
			// 
			this.btn_protect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_protect.Image = ((System.Drawing.Image)(resources.GetObject("btn_protect.Image")));
			this.btn_protect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_protect.Location = new System.Drawing.Point(8, 8);
			this.btn_protect.Name = "btn_protect";
			this.btn_protect.Size = new System.Drawing.Size(400, 32);
			this.btn_protect.TabIndex = 9;
			this.btn_protect.Text = " ⁄ÌÌ‰ Å”Ê—œ";
			this.btn_protect.Click += new System.EventHandler(this.btn_protect_Click);
			// 
			// tmr_advrs
			// 
			this.tmr_advrs.Enabled = true;
			this.tmr_advrs.Interval = 17000;
			this.tmr_advrs.Tick += new System.EventHandler(this.tmr_advrs_Tick);
			// 
			// frm_news
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 19);
			this.ClientSize = new System.Drawing.Size(420, 514);
			this.ControlBox = false;
			this.Controls.Add(this.tab_main);
			this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_news";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Œ»— ‰«„Â - „Ê””Â êÌ«Â«‰ œ«—Ê∆Ì “«ê—”";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.frm_news_Activated);
			this.tab_main.ResumeLayout(false);
			this.tbp_message.ResumeLayout(false);
			this.tbp_users.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dg_users)).EndInit();
			this.tbp_security.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.web_connection)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frm_news());
		}

		private DataSet ds_users_pub = new DataSet();
		private byte advrs = 0;

		public void connect()
		{
			try
			{
				web_connection.Offline = false;
				web_connection.Navigate("http://www.zagros-herb.com/administration.aspx");
			}
			catch (System.Exception exp)
			{
				MessageBox.Show(String.Concat("\n\tÌﬂÌ «“ Œÿ«Â«Ì “„«‰ «Ã—« œ— ”Ì” „ ‘„« —Œ œ«œÂ «” ∫  Ê÷ÌÕ«  »Ì‘ — ‘«„· ÅÌ€«„ “Ì— „Ì »«‘œ\t\n\n\n\n", "\tDetail:\n\t\t", exp.Message, "\t\n\n"), "Œÿ«Ì “„«‰ «Ã—«", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			web_connection.Select();
		}

		public void users_list()
		{
			dg_users.DataSource = null;
			txt_mail.Clear();
			txt_news.Clear();
			txt_name.Clear();
			txt_family.Clear();
			txt_sex.Clear();
			txt_age.Clear();
			txt_license.Clear();
			txt_job.Clear();
			txt_province.Clear();
			txt_city.Clear();
			txt_address.Clear();
			txt_postalcode.Clear();
			txt_tel.Clear();
			txt_fax.Clear();

			zagros_srv.zagros srv = new zagros_srv.zagros();
			DataSet ds = new DataSet();
			DataTable dt = new DataTable();
			DataRow drt;

			try
			{
				ds = srv.users_list();

				dt.Columns.Add("Å”  «·ﬂ —Ê‰ÌﬂÌ");
				dt.Columns.Add("Ê÷⁄Ì  «—”«· Œ»—‰«„Â");
				dt.Columns.Add("‰«„");
				dt.Columns.Add("‰«„ Œ«‰Ê«œêÌ");
				dt.Columns.Add("Ã‰”Ì ");
				dt.Columns.Add("”‰");
				dt.Columns.Add("„œ—ﬂ Ê —‘ Â  Õ’Ì·Ì");
				dt.Columns.Add("‘€·");
				dt.Columns.Add("«” «‰");
				dt.Columns.Add("‘Â—” «‰");
				dt.Columns.Add("¬œ—”");
				dt.Columns.Add("ﬂœÅ” Ì");
				dt.Columns.Add(" ·›‰");
				dt.Columns.Add("›«ﬂ”");
				dt.TableName = "users";
				
				int counter = 0;
				if (ds.Tables["users"].Rows.Count > 0)
				{
					foreach (DataRow dr in ds.Tables["users"].Rows)
					{
						drt = dt.NewRow();
						drt[0] = ds.Tables["users"].Rows[counter]["E-Mail"].ToString().Trim();
						drt[1] = Convert.ToBoolean(ds.Tables["users"].Rows[counter]["news"]) == true ? "»·Â" : "ŒÌ—";
						drt[2] = ds.Tables["users"].Rows[counter]["name"].ToString().Trim();
						drt[3] = ds.Tables["users"].Rows[counter]["family"].ToString().Trim();
						drt[4] = Convert.ToBoolean(ds.Tables["users"].Rows[counter]["sex"]) == true ? "„—œ" : "“‰";
						drt[5] = ds.Tables["users"].Rows[counter]["age"].ToString().Trim();
						drt[6] = ds.Tables["users"].Rows[counter]["license"].ToString().Trim();
						drt[7] = ds.Tables["users"].Rows[counter]["job"].ToString().Trim();
						drt[8] = ds.Tables["users"].Rows[counter]["province"].ToString().Trim();
						drt[9] = ds.Tables["users"].Rows[counter]["city"].ToString().Trim();
						drt[10] = ds.Tables["users"].Rows[counter]["address"].ToString().Trim();
						drt[11] = ds.Tables["users"].Rows[counter]["postalcode"].ToString().Trim();
						drt[12] = ds.Tables["users"].Rows[counter]["tel"].ToString().Trim();
						drt[13] = ds.Tables["users"].Rows[counter]["fax"].ToString().Trim();
						dt.Rows.Add(drt);
						counter++;
					}
				}
				MessageBox.Show(String.Concat(" ⁄œ«œ «⁄÷« Ê ﬂ«—»—«‰ Ê» ”«Ì : ", Convert.ToString(counter)), "„Ê””Â êÌ«Â«‰ œ«—Ê∆Ì “«ê—”", MessageBoxButtons.OK, MessageBoxIcon.Information);

				dg_users.DataSource = dt;
				ds_users_pub.Tables.Clear();
				ds_users_pub.Tables.Add(dt);
				assign();
			}
			catch (System.Exception exp)
			{
				MessageBox.Show(String.Concat("\n\tÌﬂÌ «“ Œÿ«Â«Ì “„«‰ «Ã—« œ— ”Ì” „ ‘„« —Œ œ«œÂ «” ∫  Ê÷ÌÕ«  »Ì‘ — ‘«„· ÅÌ€«„ “Ì— „Ì »«‘œ\t\n\n\n\n", "\tDetail:\n\t\t", exp.Message, "\t\n\n"), "Œÿ«Ì “„«‰ «Ã—«", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			drt = null;
			dt.Dispose();
			dt = null;
			ds.Dispose();
			ds = null;

			dg_users.Select();
		}

		public void assign()
		{
			txt_mail.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][0].ToString();
			txt_news.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][1].ToString();
			txt_name.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][2].ToString();
			txt_family.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][3].ToString();
			txt_sex.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][4].ToString();
			txt_age.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][5].ToString();
			txt_license.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][6].ToString();
			txt_job.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][7].ToString();
			txt_province.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][8].ToString();
			txt_city.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][9].ToString();
			txt_address.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][10].ToString();
			txt_postalcode.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][11].ToString();
			txt_tel.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][12].ToString();
			txt_fax.Text = ds_users_pub.Tables["users"].Rows[dg_users.CurrentRowIndex][13].ToString();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			Application.Exit();
		}

		private void ctx_attachment_Popup(object sender, System.EventArgs e)
		{
			if (lst_attachment.Items.Count == 0)
			{
				mnu_Clear.Enabled = false;
				mnu_ClearAll.Enabled = false;
			}
			else
			{
				mnu_Clear.Enabled = true;
				mnu_ClearAll.Enabled = true;
			}
			if (lst_attachment.SelectedIndex < 0)
			{
				mnu_Clear.Enabled = false;
			}
			else
			{
				mnu_Clear.Enabled = true;
			}
		}

		private void mnu_ClearAll_Click(object sender, System.EventArgs e)
		{
			btn_attachment.Enabled = true;
			lst_attachment.Items.Clear();
		}

		private void mnu_Clear_Click(object sender, System.EventArgs e)
		{
			lst_attachment.Items.RemoveAt(lst_attachment.SelectedIndex);
			if (lst_attachment.Items.Count < 99)
				btn_attachment.Enabled = true;
		}

		private void btn_attachment_Click(object sender, System.EventArgs e)
		{
			this.Enabled = false;

			ofd_attachment.Filter = " „«„Ì ›«Ì· Â« (*.*)|*.*";
			if (ofd_attachment.ShowDialog() == DialogResult.OK)
				lst_attachment.Items.Add(ofd_attachment.FileName);
			if (lst_attachment.Items.Count >= 99)
			{
				btn_attachment.Enabled = false;
				MessageBox.Show("Õœ«ﬂÀ—  ⁄œ«œ ÷„«∆„ 99 ⁄œœ „Ì »«‘œ", "„Ê””Â êÌ«Â«‰ œ«—Ê∆Ì “«ê—”", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			this.Enabled = true;
		}

		private void txt_protect_Enter(object sender, System.EventArgs e)
		{
			txt_protect.Clear();
			txt_protect.PasswordChar = '*';
			btn_send.Enabled = true;
		}

		private void tab_main_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (tab_main.SelectedTab == tbp_users)
			{
				this.Enabled = false;

				users_list();

				this.Enabled = true;
			}
			else if (tab_main.SelectedTab == tbp_security)
				connect();
		}

		private void btn_protect_Click(object sender, System.EventArgs e)
		{
			connect();
		}

		private void btn_send_Click(object sender, System.EventArgs e)
		{
			this.Enabled =false;

			bool validated = false;
			zagros_srv.zagros srv = new zagros_srv.zagros();

			try
			{
				string pw = srv.administration();
				if (pw == txt_protect.Text)
				{
					validated = true;
				}
				else
				{
					MessageBox.Show("ﬂ·„Â Ì ⁄»Ê— Ê«—œ ‘œÂ „⁄ »— ‰„Ì »«‘œ", "„Ê””Â êÌ«Â«‰ œ«—Ê∆Ì “«ê—”", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (System.Exception exp)
			{
				MessageBox.Show(String.Concat("\n\tÌﬂÌ «“ Œÿ«Â«Ì “„«‰ «Ã—« œ— ”Ì” „ ‘„« —Œ œ«œÂ «” ∫  Ê÷ÌÕ«  »Ì‘ — ‘«„· ÅÌ€«„ “Ì— „Ì »«‘œ\t\n\n\n\n", "\tDetail:\n\t\t", exp.Message, "\t\n\n"), "Œÿ«Ì “„«‰ «Ã—«", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (validated == true)
			{
				frm_status frm = new frm_status();

				StringBuilder sb = new StringBuilder();
				sb.Append("<html dir='rtl'><head><meta http-equiv='Content-Type' content='text/html; charset=utf-8'><title>„Ê””Â êÌ«Â«‰ œ«—Ê∆Ì “«ê—”</title><style type='text/css'><!--body,td,th {	font-family: Tahoma;}a:link {	text-decoration: none;}a:visited {	text-decoration: none;}a:hover {	text-decoration: underline;}a:active {	text-decoration: none;}--></style></head><body><font face='Tahoma'><div align='justify'>");
				sb.Append("<p>&nbsp;</p>");
				sb.Append("<p align='center'>");
				sb.Append(txt_subject.Text.Trim());
				sb.Append("</P><p align='right'>");
				sb.Append(txt_body.Text.Trim());
				sb.Append("</P>");
				sb.Append("<p>&nbsp;</p>");
				sb.Append("</div></font></body></html>");

				frm.all_of_them = chk_all_of_them.Checked;
				frm.subject = txt_subject.Text.Trim();
				frm.body = sb.ToString();

				int attach_num = lst_attachment.Items.Count;
				int counter = 0;

				frm.attachment[0] = "";
				Array.Clear(frm.attachment, 0, 100);
				while (counter < attach_num)
				{
					frm.attachment[counter] = lst_attachment.Items[counter].ToString().Trim();
					counter++;
				}

				frm.ShowDialog(this);
				txt_protect.Clear();
				this.Focus();
				frm.Dispose();
				frm = null;
			}

			this.Enabled =true;
		}

		private void frm_news_Activated(object sender, System.EventArgs e)
		{
			txt_subject.Focus();
		}

		private void dg_users_CurrentCellChanged(object sender, System.EventArgs e)
		{
			assign();
		}

		private void tmr_advrs_Tick(object sender, System.EventArgs e)
		{
			switch(advrs)
			{
				case 0:
					this.Text = "Œ»— ‰«„Â - „Ê””Â êÌ«Â«‰ œ«—Ê∆Ì “«ê—”";
					advrs++;
					break;
				case 1:
					this.Text = "http://www.zagros-herb.com/";
					advrs++;
					break;
				case 2:
					this.Text = "zagros-herb.com";
					advrs++;
					break;
				case 3:
					this.Text = "ÿ—«ÕÌ Ê »—‰«„Â ‰ÊÌ”Ì: „Õ„œ ’«œﬁ »«»«∆Ì";
					advrs = 0;
					break;
				default:
					break;
			}
		}
	}
}