<html>

<head>
	<meta http-equiv='Content-Type' content='text/html; charset=windows-1251'>
	<meta http-equiv='Content-Language' content='bg'>
	<title>���� "���������� �� ��� ���������� � .NET Framework � ASP.NET"</title>
</head>

<body>
<?php
	$fileName = strtolower($_FILES['userfile']['name']);
	$fileExtension = strrchr($fileName, '.');
	$fn = ereg_replace('[^0-9]','',$_POST['fn']);
	$fileSize = $_FILES['userfile']['size'];
	if (($fileExtension != '.zip') && ($fileExtension != '.rar')) {
		error('��������� ����. ������� �� ���� .zip � .rar �������!');
	} else if (($fileSize < 1) || ($fileSize > 4*1024*1024)) {
		error('��������� ����. ������� �� ���� ������� � ����� �� 4 �B!');
	} else if ((strlen($fn) < 2) || (strlen($fn) > 12)) {
		error('��������� ���������� �����!');
	} else {
		$uploadDir = '/www/devbg.org/nakov/aspnetcourse-uploaded-files';
		$date = date("Y-m-d-h-i-s");
		$storeFileName = $uploadDir.'/'.'fn'.$fn.'-'.$date.$fileExtension;
		if (move_uploaded_file($_FILES['userfile']['tmp_name'], $storeFileName)) {
			$displayDate = date("Y-m-d h:i:s");
?>
			<font size="5">������ � ������� �������.</font>
			<br>
			<br>
			���������� �����: <?= $fn ?><br>
			���� � ���: <?= $displayDate ?><br>
			������ �� ��������� ����: <?= $fileSize ?> �����<br>
<?php
		} else {
			error('�������� ���������� ������ ��� ������������ �� ����� ����!');
		}
	}
?>
</body>

</html>

<?php
	function error($message)
	{
?>
		<font size="5" color="Red"><strong>������:</strong></font>
		<font size="5"><?= $message ?></font>
<?php
	}
?>
