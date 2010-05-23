<html>

<head>
	<meta http-equiv='Content-Type' content='text/html; charset=windows-1251'>
	<meta http-equiv='Content-Language' content='bg'>
	<title>Курс "Разработка на уеб приложения с .NET Framework и ASP.NET"</title>
</head>

<body>

	<form action="upload.php" method="post" enctype="multipart/form-data">
		<p style="text-align:center">
			<font size="5">
				Система за изпращане на курсови проекти по<br>
				"Разработка на уеб приложения с .NET Framework и ASP.NET"
			</font>
		</p>
		<p style="text-align:center">
			<font size="4">
				Приемат се само .ZIP и .RAR файлове с размер до 4 MB.
			</font>
		</p>
		<table align="center" style="{border:1px solid blue; padding:10px 10px 10px 10px;}">
			<tr><td>
				<table cellspacing="8" cellpadding="0" border="0">
					<tr>
						<td width="150" height="20">Факултетен номер:</td>
						<td><input type="text" maxLength="10" size="10" name="fn"></td>
					</tr>
					<tr>
						<td width="150" height="20">Изберете файл:</td>
						<td><input type="file" name="userfile" size="50"></td>
					</tr>
					<tr>
						<td colspan="2" align="center" style="{padding-top:0px;}">
							<input type="submit" value="Изпращане" name="submit">
						</td>
					</tr>
				</table>
			</td></tr>
		</table>
		<p style="text-align:justify">
			<i>Забележка:</i>
			Можете да изпращате проектите си по няколко пъти, стига да не е	изтекъл	крайният
			срок за предаване. За всеки факултетен номер ще бъде разгледан и оценен само
			последният изпратен проект. В случай на конфликт (заради липсата на автентикация)
			случаите ще бъдат разрешавани индивидиално. Системата запазва всички успешно
			изпратени файлове за всеки факултетен номер.
			<br>
		</p>
	</form>

</body>

</html>
