<%@ Page language="c#" Codebehind="registerforautonews.aspx.cs" AutoEventWireup="false" Inherits="zagros_herb.registerforautonews" errorPage="error.html" codePage="1200" %>
<HTML lang="fa" dir="rtl">
	<HEAD>
		<title>خبرنامه</title>
		<meta http-equiv="Content-Type" content="text/html; charset=unicode">
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
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
		<form id="wfrm_RegisterForAutoNews" method="post" runat="server">
			<FONT face="Tahoma">
				<P align="justify">&nbsp;
					<asp:label id="lbl_panel" style="Z-INDEX: 113; LEFT: 24px; POSITION: absolute; TOP: 24px" runat="server"
						Font-Names="Tahoma" Width="409px" Height="48px" Font-Bold="True" ForeColor="Blue">جهت ارسال يا عدم ارسال خبرنامه به آدرس پست الكترونيكي خود، آدرس پست الكترونيكي و كلمه ي عبور خود در هنگام ثبت نام در سايت را وارد نمائيد.</asp:label>
					<asp:label id="lbl_panel_warning" style="Z-INDEX: 114; LEFT: 24px; POSITION: absolute; TOP: 96px"
						runat="server" Font-Names="Tahoma" Width="409px" Height="48px" Font-Bold="True" ForeColor="Blue">توجه نمائيد كه جهت استفاده از خبرنامه ايتدا بايستي در سايت ثبت نام نمائيد.</asp:label>
					<asp:label id="lbl_status_warn" style="Z-INDEX: 115; LEFT: 24px; POSITION: absolute; TOP: 152px"
						runat="server" Font-Names="Tahoma" Width="409px" Height="48px" Font-Bold="True" ForeColor="Blue">سپس در اين جا مي توانيد وضعيت ارسال خبرنامه را تنظيم نمائيد.</asp:label>
					<asp:validationsummary id="vs_generated_err" style="Z-INDEX: 116; LEFT: 24px; POSITION: absolute; TOP: 224px"
						runat="server" Font-Names="Tahoma" Width="409px" Height="48px"></asp:validationsummary>
					<asp:label id="lbl_register_email" style="Z-INDEX: 117; LEFT: 304px; POSITION: absolute; TOP: 304px"
						runat="server" Font-Names="Tahoma" Width="128px">پست الكترونيكي:</asp:label>
					<asp:textbox id="txt_registerd_email" style="Z-INDEX: 118; LEFT: 32px; POSITION: absolute; TOP: 304px"
						tabIndex="1" runat="server" Font-Names="Tahoma" Width="256px" MaxLength="255"></asp:textbox>
					<asp:regularexpressionvalidator id="rev__register_email" style="Z-INDEX: 119; LEFT: 16px; POSITION: absolute; TOP: 304px"
						runat="server" Font-Names="Tahoma" ControlToValidate="txt_registerd_email" ErrorMessage="آدرس پست الكترونيكي وارد شده معتبر نمي باشد..."
						ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:regularexpressionvalidator>
					<asp:requiredfieldvalidator id="rfv__register_email" style="Z-INDEX: 120; LEFT: 16px; POSITION: absolute; TOP: 304px"
						runat="server" ControlToValidate="txt_registerd_email" ErrorMessage="لطفا آدرس پست الكترونيكي خود را وارد نمائيد...">*</asp:requiredfieldvalidator>
					<asp:label id="lbl_pw" style="Z-INDEX: 121; LEFT: 344px; POSITION: absolute; TOP: 336px" runat="server"
						Font-Names="Tahoma">كلمه ي عبور:</asp:label>
					<asp:textbox id="txt_pw" style="Z-INDEX: 122; LEFT: 32px; POSITION: absolute; TOP: 336px" tabIndex="2"
						runat="server" Font-Names="Tahoma" Width="256px" MaxLength="20" TextMode="Password"></asp:textbox>
					<asp:requiredfieldvalidator id="rfv_pw" style="Z-INDEX: 123; LEFT: 16px; POSITION: absolute; TOP: 336px" runat="server"
						Font-Names="Tahoma" ControlToValidate="txt_pw" ErrorMessage="لطفا كلمه ي عبور را وارد نمائيد...">*</asp:requiredfieldvalidator>
					<asp:RadioButtonList id="rbl_status" style="Z-INDEX: 124; LEFT: 32px; POSITION: absolute; TOP: 392px"
						tabIndex="3" runat="server" Font-Names="Tahoma" Width="401px">
						<asp:ListItem Value="send" Selected="True">ارسال خودكار خبرنامه</asp:ListItem>
						<asp:ListItem Value="terminate">عدم ارسال خبرنامه</asp:ListItem>
					</asp:RadioButtonList>
					<asp:Button id="btn_submit" style="Z-INDEX: 125; LEFT: 32px; POSITION: absolute; TOP: 464px"
						tabIndex="4" runat="server" Font-Names="Tahoma" Width="401px" Text="تائيد" Height="32px"></asp:Button>
				</P>
		</form>
		</FONT>
	</body>
</HTML>
