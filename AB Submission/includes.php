<?php
include 'dbh.inc.php';
?>
<html>
<head>
	<meta charset="UTF-8" />
	<title>Title of the document</title>

</head>
<header>
	<h1>NSN NUMBER LOOKUP</h1>
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
	// Gets NSN num from hyperlink and displays the number that was clicked on
	$nsnnum = $_GET['nsnnum'];
	echo "You have selected to view the NSN number $nsnnum.";
	echo "<br>";
	// Gets the NIIN number so that it can be searched for in the database to display info required
	$nsnnumtrans = $_GET['niinnum'];

	echo "<br>";
	// Searches database for the NIIN number to display
	$sql = "SELECT * FROM `nsn` WHERE NIIN=$nsnnumtrans;";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
		}
	}
	// Also searchs the database for the NSN_CHARACTERISTICS to add to the page if any are there
	$sql = "SELECT * FROM `nsn_characteristics` WHERE NIIN=$nsnnumtrans;";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
		}
	}
	// Also searchs the database for the NSN_FLIS_PARTS to add to the page if any are there
	$sql = "SELECT * FROM `nsn_flis_parts` WHERE NIIN=$nsnnumtrans;";
	$result = mysqli_query($conn, $sql);
	$resultCheck = mysqli_num_rows($result);

	if ($resultCheck > 0) {
		while ($row = mysqli_fetch_assoc($result)) {
			echo '<pre>'; print_r($row); echo '</pre>';
			echo "<br>";
		}
	}


    ?>
	<br />
	<br />
	<a href="index.php">RETURN TO HOME PAGE</a>



</body>

</html>