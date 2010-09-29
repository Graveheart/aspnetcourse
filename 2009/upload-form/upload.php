<html>

<head>
	<meta http-equiv='Content-Type' content='text/html; charset=windows-1251'>
	<meta http-equiv='Content-Language' content='bg'>
	<title>Курс "Разработка на уеб приложения с .NET Framework и ASP.NET"</title>
</head>

<body>
<?php
	$fileName = strtolower($_FILES['userfile']['name']);
	$fileExtension = strrchr($fileName, '.');
	$fn = ereg_replace('[^0-9]','',$_POST['fn']);
	$fileSize = $_FILES['userfile']['size'];
	if (($fileExtension != '.zip') && ($fileExtension != '.rar')) {
		error('Невалиден файл. Приемат се само .zip и .rar файлове!');
	} else if (($fileSize < 1) || ($fileSize > 4*1024*1024)) {
		error('Невалиден файл. Приемат се само файлове с рамер до 4 МB!');
	} else if ((strlen($fn) < 2) || (strlen($fn) > 12)) {
		error('Невалиден факултетен номер!');
	} else {
		$uploadDir = '/www/devbg.org/nakov/aspnetcourse-uploaded-files';
		$date = date("Y-m-d-h-i-s");
		$storeFileName = $uploadDir.'/'.'fn'.$fn.'-'.$date.$fileExtension;
		if (move_uploaded_file($_FILES['userfile']['tmp_name'], $storeFileName)) {
			$displayDate = date("Y-m-d h:i:s");
?>
			<font size="5">Файлът е получен успешно.</font>
			<br>
			<br>
			Факултетен номер: <?= $fn ?><br>
			Дата и час: <?= $displayDate ?><br>
			Размер на получения файл: <?= $fileSize ?> байта<br>
<?php
		} else {
			error('Възникна неочаквана грешка при получаването на вашия файл!');
		}
	}
?>
</body>

</html>

<?php
	function error($message)
	{
?>
		<font size="5" color="Red"><strong>Грешка:</strong></font>
		<font size="5"><?= $message ?></font>
<?php
	}
?>
