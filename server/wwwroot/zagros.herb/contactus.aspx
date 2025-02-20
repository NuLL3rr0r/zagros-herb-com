<%@ Page language="c#" Codebehind="contactus.aspx.cs" AutoEventWireup="false" Inherits="zagros_herb.wfrm_ContactUs" errorPage="error.html" codePage="1200" %>
<HTML lang="fa" dir="rtl">
	<HEAD>
		<title>تماس با ما</title>
		<meta http-equiv="Content-Type" content="text/html; charset=unicode">
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
<script language="JavaScript1.2">
document.onmousedown=click
function click()
{
	if ((event.button==2) || (event.button==3))
	{
		if (document.all)
		{
			top.window.resizeTo(0,0);
		}
		else if (document.layers||document.getElementById)
		{
			if (top.window.outerHeight<screen.availHeight||top.window.outerWidth<screen.availWidth)
			{
				top.window.outerHeight = 0;
				top.window.outerWidth = 0;
			}
		}
		alert('right click was disabled...');
		window.close();
	}
}
</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout" onkeypress="if (window.event.keyCode == 27) window.close()">
		<form id="wfrm_ContactUs" method="post" runat="server">
			<FONT face="Tahoma">
				<P align="justify">
					<asp:label id="lbl_panel" style="Z-INDEX: 121; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server"
						Font-Names="Tahoma" ForeColor="Blue" Font-Bold="True">شما مي توانيد پيام خود را در قسمت زير وارد نمائيد:</asp:label>
					<asp:validationsummary id="vs_generated_err" style="Z-INDEX: 122; LEFT: 24px; POSITION: absolute; TOP: 48px"
						runat="server" Height="32px" Width="369px" Font-Names="Tahoma"></asp:validationsummary>
					<asp:label id="lbl_name" style="Z-INDEX: 123; LEFT: 344px; POSITION: absolute; TOP: 168px"
						runat="server" Font-Names="Tahoma">نام:</asp:label>
					<asp:textbox id="txt_name" style="Z-INDEX: 124; LEFT: 48px; POSITION: absolute; TOP: 168px" tabIndex="1"
						runat="server" Width="289px" Font-Names="Tahoma"></asp:textbox>
					<asp:requiredfieldvalidator id="rfV_name" style="Z-INDEX: 125; LEFT: 32px; POSITION: absolute; TOP: 168px" runat="server"
						Font-Names="Tahoma" ControlToValidate="txt_name" ErrorMessage="لطفا نام خود را وارد نمائيد...">*</asp:requiredfieldvalidator>
					<asp:label id="lbl_email" style="Z-INDEX: 126; LEFT: 344px; POSITION: absolute; TOP: 200px"
						runat="server" Font-Names="Tahoma">E-Mail:</asp:label>
					<asp:textbox id="txt_email" style="Z-INDEX: 127; LEFT: 48px; POSITION: absolute; TOP: 200px"
						tabIndex="2" runat="server" Width="289px" Font-Names="Tahoma"></asp:textbox>
					<asp:regularexpressionvalidator id="rev_email" style="Z-INDEX: 128; LEFT: 32px; POSITION: absolute; TOP: 200px"
						runat="server" Font-Names="Tahoma" ControlToValidate="txt_email" ErrorMessage="آدرس E-Mail وارد شده معتبر نمي باشد..."
						ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:regularexpressionvalidator>
					<asp:requiredfieldvalidator id="rfv_email" style="Z-INDEX: 129; LEFT: 32px; POSITION: absolute; TOP: 200px"
						runat="server" Font-Names="Tahoma" ControlToValidate="txt_email" ErrorMessage="لطفا آدرس E-Mail خود را وارد نمائيد...">*</asp:requiredfieldvalidator>
					<asp:label id="lbl_url" style="Z-INDEX: 130; LEFT: 344px; POSITION: absolute; TOP: 232px" runat="server"
						Font-Names="Tahoma">URL:</asp:label>
					<asp:textbox id="txt_url" style="Z-INDEX: 131; LEFT: 48px; POSITION: absolute; TOP: 232px" tabIndex="3"
						runat="server" Width="289px" Font-Names="Tahoma"></asp:textbox>
					<asp:regularexpressionvalidator id="rev_url" style="Z-INDEX: 132; LEFT: 32px; POSITION: absolute; TOP: 232px" runat="server"
						Font-Names="Tahoma" ControlToValidate="txt_url" ErrorMessage="URL وارد شده معتبر نمي باشد..." ValidationExpression="http://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?">*</asp:regularexpressionvalidator>
					<asp:label id="lbl_subject" style="Z-INDEX: 133; LEFT: 344px; POSITION: absolute; TOP: 264px"
						runat="server" Font-Names="Tahoma">موضوع:</asp:label>
					<asp:textbox id="txt_subject" style="Z-INDEX: 134; LEFT: 48px; POSITION: absolute; TOP: 264px"
						tabIndex="4" runat="server" Width="289px" Font-Names="Tahoma"></asp:textbox>
					<asp:requiredfieldvalidator id="rfv_subject" style="Z-INDEX: 135; LEFT: 32px; POSITION: absolute; TOP: 264px"
						runat="server" Font-Names="Tahoma" ControlToValidate="txt_subject" ErrorMessage="لطفا موضوع پيام را وارد نمائيد...">*</asp:requiredfieldvalidator>
					<asp:label id="lbl_message" style="Z-INDEX: 136; LEFT: 344px; POSITION: absolute; TOP: 296px"
						runat="server" Font-Names="Tahoma">متن پبام:</asp:label>
					<asp:textbox id="txt_message" style="Z-INDEX: 137; LEFT: 48px; POSITION: absolute; TOP: 296px"
						tabIndex="5" runat="server" TextMode="MultiLine" Height="200px" Width="289px" Font-Names="Tahoma"></asp:textbox>
					<asp:requiredfieldvalidator id="rfv_message" style="Z-INDEX: 138; LEFT: 32px; POSITION: absolute; TOP: 296px"
						runat="server" Font-Names="Tahoma" ControlToValidate="txt_message" ErrorMessage="لطفا پيام مورد نظرتان را وارد نمائيد...">*</asp:requiredfieldvalidator>
					<asp:button id="btn_send" style="Z-INDEX: 139; LEFT: 168px; POSITION: absolute; TOP: 512px"
						tabIndex="6" runat="server" Font-Names="Tahoma" Text="   ارسال   "></asp:button>
					<asp:button id="btn_cancel" style="Z-INDEX: 140; LEFT: 48px; POSITION: absolute; TOP: 512px"
						tabIndex="7" runat="server" Font-Names="Tahoma" Text="   فرم خالي   " CausesValidation="False"></asp:button>
				</P>
		</form>
		</FONT>
	</body>
</HTML>
