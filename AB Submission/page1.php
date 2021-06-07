<?php
include 'dbh.inc.php';


?>

<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8" />
	<title>Title of the document</title>
</head>
<header>
	<h1>USER LOOKUP OF NSN NUMBER</h1>
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
	//  Pulls info for the number typed into the search box on each page
	if(isset($_POST['submit'])){
		$nsnsearch = $_POST['nsnsearchnum'];
		// Informs user of the item that was searched for
		echo "You have searched for NSN number: $nsnsearch.";
		echo "<br>";
		// Makes the NSN number into the NIIN number to search the database
		$niinsearch = substr($nsnsearch, -9);
		// Searches the database for NIIN number and displays info
		$sql = "SELECT * FROM `nsn` WHERE NIIN=$niinsearch;";
		$result = mysqli_query($conn, $sql);
		$resultCheck = mysqli_num_rows($result);

		if ($resultCheck > 0) {
			while ($row = mysqli_fetch_assoc($result)) {
				echo '<pre>'; print_r($row); echo '</pre>';
				echo "<br>";
			}
		}else {
			echo "You have searched for a NSN number which does not exist. Please search again.";
		}
		// Also searches the NSN_CHARACTERISTICS for the NIIN number to display any info that might be stored there as well
		$sql = "SELECT * FROM `nsn_characteristics` WHERE NIIN=$niinsearch;";
		$result = mysqli_query($conn, $sql);
		$resultCheck = mysqli_num_rows($result);

		if ($resultCheck > 0) {
			while ($row = mysqli_fetch_assoc($result)) {
				echo '<pre>'; print_r($row); echo '</pre>';
				echo "<br>";
			}
		}

		// Also searchs the database for the NSN_FLIS_PARTS to add to the page if any are there
		$sql = "SELECT * FROM `nsn_flis_parts` WHERE NIIN=$niinsearch;";
		$result = mysqli_query($conn, $sql);
		$resultCheck = mysqli_num_rows($result);

		if ($resultCheck > 0) {
			while ($row = mysqli_fetch_assoc($result)) {
				echo '<pre>'; print_r($row); echo '</pre>';
				echo "<br>";
			}
		}


	}

    ?>
	<br />
	<br />
	<a href="index.php">RETURN TO HOME PAGE</a>

</body>

</html>