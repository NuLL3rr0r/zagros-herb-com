<%@ Page CodeBehind="default.aspx.cs" Language="c#" AutoEventWireup="false" Inherits="zagros_herb._default" errorPage="error.html" codePage="1200" %>
<HTML dir="rtl">
	<HEAD>
		<title>موسسه گياهان داروئي زاگرس</title>
		<meta http-equiv="Content-Type" content="text/html; charset=unicode">
<script language="JavaScript1.2">
top.window.moveTo(0,0);
if (document.all) {
top.window.resizeTo(screen.availWidth,screen.availHeight);
}
else if (document.layers||document.getElementById) {
if (top.window.outerHeight<screen.availHeight||top.window.outerWidth<screen.availWidth){
top.window.outerHeight = screen.availHeight;
top.window.outerWidth = screen.availWidth;
}
}
</script>
<script Language="JavaScript">
var timerID = null;
var timerRunning = false;
function stopclock (){
        if(timerRunning)
                clearTimeout(timerID);
        timerRunning = false;
}
function showtime () {
        var now = new Date();
        var hours = now.getHours();
        var minutes = now.getMinutes();
        var seconds = now.getSeconds()
        var timeValue = "" + ((hours >12) ? hours -12 :hours)
        timeValue += ((minutes < 10) ? ":0" : ":") + minutes
        timeValue += ((seconds < 10) ? ":0" : ":") + seconds
        timeValue += (hours >= 12) ? " P.M." : " A.M."
        window.status = timeValue+"   "+dayf+" "+roozf+" "+mahf+" " +sal;
        timerID = setTimeout("showtime()",1000);
        timerRunning = true;
}
function startclock () {
        stopclock();
        showtime();
}
</script>
<SCRIPT LANGUAGE="JavaScript">
var speed = 100 
var pause = 1000 
var timerID = null
var texttype = false
var ar = new Array()
ar[0] = "موسسه گياهان داروئي زاگرس"
ar[1] = "http://www.zagros-herb.com/"
ar[2] = "گياهان داروئي و داروهاي گياهي"
ar[3] = "info@zagros-herb.com"
var msgnow = 0
var offset = 0
function stopBanner() {
        if (texttype)
                clearTimeout(timerID)
        texttype = false
}
function startBanner() {
        stopBanner()
        showBanner()
}
function showBanner() {
        var text = ar[msgnow]

        if (offset < text.length) {
                if (text.charAt(offset) == " ")
                        offset++                        

                var partialMessage = text.substring(0, offset + 1) 
                document.title = partialMessage
                offset++ 
                timerID = setTimeout("showBanner()", speed)
                texttype = true
        } else {
                offset = 0
                msgnow++
                if (msgnow == ar.length)
                        msgnow = 0

                timerID = setTimeout("showBanner()", pause)
                texttype = true
        }
}
</SCRIPT>    
<script>
function run()
{
startclock();
startBanner();
}
</script>
<script language="JavaScript">
var day="";
var month="";
var myweekday="";
var year="";
var timerID = null;
var timerRunning = false;
var dayf="";
var sal="";
var roozf="";
var mahf="";
mydate = new Date();
myday = mydate.getDay();
mymonth = mydate.getMonth();
myweekday= mydate.getDate();
weekday= myweekday;
myyear= mydate.getYear();
year = myyear;
if(myday == 0)
{
day = " Sunday, ";
dayf= "يكشنبه";
}
else if(myday == 1)
{
day = " Monday, ";
dayf="دوشنبه";
}
else if(myday == 2)
{
day = " Tuesday, ";
dayf="سه شنبه";
}
else if(myday == 3)
{
day = " Wednesday, ";
dayf="چهارشنبه";
}
else if(myday == 4)
{
day = " Thurday, ";
dayf="پنجشنبه";
}
else if(myday == 5)
{
day = " Friday, ";
dayf="جمعه";
}
else if(myday == 6)
{
day = " Saturday, ";
dayf="شنبه";
}
if ( ((mymonth>=0)&& (mymonth <= 1)) || ((mymonth == 2) && (myweekday <= 20)))
{
   sal = myyear - 622;
   s1 = true;
}
else
{
   sal = myyear - 621;
   s1 = false;
}
if ((myyear%4 == 0) && (myyear%400 != 0))
kabise = true;
else
kabise=false;
if (((myyear - 1) % 4 == 0) && ((myyear - 1)%400 != 0))
kabiseold = true;
else kabiseold=false;
if (myyear == 2000)
   kabise = true;
if (myyear == 2001)
   kabiseold = true;
shamsi=new Array(12);
shamsi[0] = 0;
shamsi[1] = 31;
shamsi[2] = 62;
shamsi[3] = 93;
shamsi[4] = 124;
shamsi[5] = 155;
shamsi[6] = 186;
shamsi[7] = 216;
shamsi[8] = 246;
shamsi[9] = 276;
shamsi[10] = 306;
shamsi[11] = 336;
if (kabise)
   kab = 1;
else
   kab = 0;
miladi=new Array(12);
miladi[0] = 0;
miladi[1] = 31 + kab;
miladi[2] = 59 + kab;
miladi[3] = 90 + kab;
miladi[4] = 120 + kab;
miladi[5] = 151 + kab;
miladi[6] = 181 + kab;
miladi[7] = 212 + kab;
miladi[8] = 243 + kab;
miladi[9] = 273 + kab;
miladi[10] = 304 + kab;
miladi[11] = 334 + kab;
marray=new Array(12);
marray[0] = "فروردين";
marray[1] = "ارديبهشت";
marray[2] = "خرداد";
marray[3] = "تير";
marray[4] = "مرداد";
marray[5] = "شهريور";
marray[6] = "مهر";
marray[7] = "آبان";
marray[8] = "آذر";
marray[9] = "دي";
marray[10] = "بهمن";
marray[11] = "اسفند";
if (kabiseold)
   kab1 = 1;
else
   kab1 = 0;
if (s1)
   x1 = myweekday + miladi[mymonth] + kab1;
else
   x1 = myweekday + miladi[mymonth];
if (x1< 80)
x1 = 365 - 79 + x1;
   else if (x1> 80)
        x1 = x1 - 79;
   else if (x1=80)
        {
        if(s1)
           x1 = 365 - 79 + x1;
        else
           x1 = x1 - 79;
        }
ss1 = true;
i = 12;
while (i > 0 && ss1)
{
   i = i - 1;
   if (x1 <= shamsi[i])
     ss1=true;
   else ss1=false;  
}
rooz=new Array(31);
rooz[0] = "يكم";
rooz[1] = "دوم";
rooz[2] = "سوم";
rooz[3] = "چهارم";
rooz[4] = "پنجم";
rooz[5] = "ششم";
rooz[6] = "هفتم";
rooz[7] = "هشتم";
rooz[8] = "نهم";
rooz[9] = "دهم";
rooz[10] = "يازدهم";
rooz[11] = "دوازدهم";
rooz[12] = "سيزدهم";
rooz[13] = "چهاردهم";
rooz[14] = "پانزدهم";
rooz[15] = "شانزدهم";
rooz[16] = "هفدهم";
rooz[17] = "هجدهم";
rooz[18] = "نوزدهم";
rooz[19] = "بيستم";
rooz[20] = "بيست و يكم";
rooz[21] = "بيست و دوم";
rooz[22] = "بيست و سوم";
rooz[23] = "بيست و چهارم";
rooz[24] = "بيست و پنجم";
rooz[25] = "بيست و ششم";
rooz[26] = "بيست و هفتم";
rooz[27] = "بيست و هشتم";
rooz[28] = "بيست و نهم";
rooz[29] = "سي ام";
rooz[30] = "سي و يكم";
roozf=rooz[x1 - shamsi[i]-1];
mahf=marray[i];
if(mymonth == 0) {
month = "January ";}
else if(mymonth ==1)
month = "February ";
else if(mymonth ==2)
month = "March ";
else if(mymonth ==3)
month = "April ";
else if(mymonth ==4)
month = "May ";
else if(mymonth ==5)
month = "June ";
else if(mymonth ==6)
month = "July ";
else if(mymonth ==7)
month = "August ";
else if(mymonth ==8)
month = "September ";
else if(mymonth ==9)
month = "October ";
else if(mymonth ==10)
month = "November ";
else if(mymonth ==11)
month = "December ";
</script>
    	</HEAD>
	<body bgcolor="#ffffff" onLoad="run()">
		<script language="JavaScript">
var isInternetExplorer = navigator.appName.indexOf("Microsoft") != -1;
function zagros_DoFSCommand(command, args) {
	var zagrosObj = isInternetExplorer ? document.all.zagros : document.zagros;
	switch(command)
	{
		case "menu":
			switch(args)
			{
				case "learning":
					window.open('learning.html','learning','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "research":
					window.open('research.html','research','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "extention":
					window.open('extention.html','extention','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "news":
					window.open('news.html','news','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "cure":
					window.open('cure.html','cure','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "products":
					window.open('products.html','products','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "business":
					window.open('business.html','business','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "books":
					window.open('books.html','books','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "articles":
					window.open('articles.html','articles','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "pics":
					window.open('pics.html','pics','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "autonews":
					window.open('registerforautonews.aspx','registerforautonews','fullscreen=0,location=0,menubar=0,resizable=0,scrollbars=0,status=1,titlebar=0,toolbar=0,width=470,height=510');
				  	break;
				case "profile":
					window.open('profile.aspx','profile','fullscreen=0,location=0,menubar=0,resizable=0,scrollbars=1,status=1,titlebar=0,toolbar=0,width=550,height=550');
				  	break;
				case "register":
					window.open('register.aspx','register','fullscreen=0,location=0,menubar=0,resizable=0,scrollbars=1,status=1,titlebar=0,toolbar=0,width=550,height=550');
				  	break;
				case "questions":
					window.open('questions.aspx','questions','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
					break;
				case "contactus":
					window.open('contactus.aspx','contactus','fullscreen=0,location=0,menubar=0,resizable=0,scrollbars=0,status=1,titlebar=0,toolbar=0,width=420,height=550');
				  	break;
				case "links":
					window.open('links.html','links','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
				  	break;
				case "about":
					window.open('about.html','about','fullscreen=0,location=0,menubar=0,resizable=1,scrollbars=1,status=1,titlebar=0,toolbar=0,width=800,height=600');
					break;
				default:
					break;
			}
		default:
			break;
	}
}
if (navigator.appName && navigator.appName.indexOf("Microsoft") != -1 && navigator.userAgent.indexOf("Windows") != -1 && navigator.userAgent.indexOf("Windows 3.1") == -1) {
	document.write('<script language=\"VBScript\"\>\n');
	document.write('On Error Resume Next\n');
	document.write('Sub zagros_FSCommand(ByVal command, ByVal args)\n');
	document.write('	Call zagros_DoFSCommand(command, args)\n');
	document.write('End Sub\n');
	document.write('</script\>\n');
}
		</script>
		<div align="center">
			<OBJECT id="zagros" codeBase="http://fpdownload.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=7,0,0,0"
				height="600" width="800" align="middle" classid="clsid:d27cdb6e-ae6d-11cf-96b8-444553540000">
				<PARAM NAME="_cx" VALUE="21167">
				<PARAM NAME="_cy" VALUE="15875">
				<PARAM NAME="FlashVars" VALUE="">
				<PARAM NAME="Movie" VALUE="home.swf">
				<PARAM NAME="Src" VALUE="home.swf">
				<PARAM NAME="WMode" VALUE="Window">
				<PARAM NAME="Play" VALUE="0">
				<PARAM NAME="Loop" VALUE="0">
				<PARAM NAME="Quality" VALUE="High">
				<PARAM NAME="SAlign" VALUE="">
				<PARAM NAME="Menu" VALUE="0">
				<PARAM NAME="Base" VALUE="">
				<PARAM NAME="AllowScriptAccess" VALUE="sameDomain">
				<PARAM NAME="Scale" VALUE="ShowAll">
				<PARAM NAME="DeviceFont" VALUE="0">
				<PARAM NAME="EmbedMovie" VALUE="0">
				<PARAM NAME="BGColor" VALUE="FFFFFF">
				<PARAM NAME="SWRemote" VALUE="">
				<PARAM NAME="MovieData" VALUE="">
				<PARAM NAME="SeamlessTabbing" VALUE="1">
				<embed src="home.swf" loop="false" menu="false" quality="best" bgcolor="#ffffff" width="800"
					height="600" swLiveConnect="true" id="zagros" name="zagros" align="middle" allowScriptAccess="sameDomain"
					type="application/x-shockwave-flash" pluginspage="http://www.macromedia.com/go/getflashplayer" />
			</OBJECT>
		</div>
		<DIV align="center">
			<asp:Label id="lbl_result" runat="server" Font-Names="Tahoma" ForeColor="Blue"></asp:Label></DIV>
	</body>
</HTML>