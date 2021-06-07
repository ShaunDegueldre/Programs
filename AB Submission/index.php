<?php

include 'dbh.inc.php';
?>


<!DOCTYPE html>
<html>
<link rel="stylesheet" href="style.css" />
<head>
	<meta charset="UTF-8" />
	<title>Title of the document</title>
</head>
<header>
	<h1>AeroBase Group</h1>
	<br />
</header>
<body>
	<! -- Creates the form to have the user search for a specific NSN number -->
	<form action="page1.php" method="post">
		NSN Search:
		<input type="int" name="nsnsearchnum" />
		<input type="reset" name="reset" />
		<input type="submit" name="submit" value="Search" />

	</form>
	<?php
	echo "<br>";
	// Grabs the random 15 needed to display on home page
	$sql = "SELECT * FROM nsn ORDER BY RAND() LIMIT 15;";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);
	// Checks to see if results are available and saves them to an array
	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			$arrayresult[] = $row['NIIN'];
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[0];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the first NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[1];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			echo " This is the second NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[2];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			echo " This is the third NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[3];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the fourth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[4];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the fifth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[5];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the sixth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[6];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the seventh NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[7];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the eighth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[8];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the ninth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[9];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the tenth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[10];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the eleventh NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[11];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the twelfth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[12];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the thirteenth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[13];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the fourteenth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
	// Displays the NSN number along with hyperlink and creates the NSN num from provided information from database
	// Carrys the NIIN and NSN numbers over with the hyperlink
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$arrayresult[14];";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			//echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
			$arrayresult[] = $row['NIIN'];
			$fscresult = $row['FSC'];
			$niinresult = $row['NIIN'];
			$fscfullresult = str_pad($fscresult, 13, '0', STR_PAD_RIGHT);
			$fullniinresult = str_pad($niinresult, 9, '0', STR_PAD_LEFT);
			$nsnnum = $fscfullresult + $fullniinresult;
			$nsnnum1 = $nsnnum;
			echo "This is the fifteenth NSN number $nsnnum randomly selected.";
			echo " Click ";
			echo '<a href="includes.php?niinnum=' . $niinresult . '&nsnnum=' . $nsnnum . '">HERE</a>';
			echo " to view this Product.";
			echo "<br>";
		}
	}
    ?>
</body>
</html>