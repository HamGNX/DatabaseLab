<html>
<?php error_reporting(~E_NOTICE); ?>
<!-- link to the style sheet "default1.css"-->
<link rel="stylesheet" href="default1.css">

<!-- Add the given image "back.jpg" as illustrated (no repeat and cover the page) -->

<body>
	<!-- Add php content to restrict only the user with password to enter -->

	<!-- php file begin-->
    <?php
	// Assign the variables for username and password (user name: Admin and Password: 1234) 
	
	// Perhaps you need this: session_start();

	// Check if username is Admin and password is 1234 and confirm password is 1234
	//if($username ==  && $pass== && $pass1== )	
	//	{
	//		$_SESSION["username"] = $username;    
	//	}
	//else
	//	{
	//		echo "<h1>", "You do not have access to this page!" ,"</h1>";
		

	//		if (????????????????) {	// Check if the session started or not; if not, set the start time
				
				

	//		} 
				// Calculate the number of seconds (counter) that have passed since the session started
			

			
	//			echo "<p>","You will be given the redirecting button after ", $elapsed_time, " seconds </p><br>";
				

	//			if (???) { // If counter is greater than 30
	//				$txt = "history.go(-1);";
	//				echo "<button onclick='$txt'>Back </button>";
					// unset all session variables
					// destroy all session variables
	//			} else {
	//				header("Refresh:1");	// Keep refreshing the page
	//			}
			
			
	//		exit;	// Stop further processing the page
	//	} 
	//  php file end
		?>
	<!-- the heading is given as " Welcome Mr./Mrs./Ms. User Name", change the font to Arial, size of font to 200%, make the text appear in center-->
	<h1> Welcome <?php echo $_POST["title"], " ", $_POST["firstname"], " ", $_POST["lastname"], "!!!"; ?><br> </h1>
	<!-- add the image "avatar.png", height to 240 pixels-->

	<!-- change the font to Arial,size of font to 170%-->
	<h3> This is your profile </h3>

	<!-- change the font to Arial-->
	<p>
		<?php
		echo "Name:", " ", $_POST["title"], " ", $_POST["firstname"], " ", $_POST["lastname"], "<br>";
		//--add "User Group: usergroup"-- 

		//-- add "Email address: Email"-- 

		//-- Find the gender and output "Gender: gender"-- 





		//-- Find the age and output as "Age in years: age"--
		// $bday = $_POST["birth"]; // Your date of birth

		//-- set default time zone--
		date_default_timezone_set("Asia/Bangkok");
		//-- print the login type as " Login time (local): time on date"-- 


		?>
	</p>

	<!-- change font to Arial, bold and font size to 150%-->
	<p> Welcome to the CSS326 system <br></p>
	<p style="font-family: Arial">
		Whether you are an experienced programmer or not, this website is intended for everyone who wishes to learn Database programming.
		There is no need to download anything - just click on the chapter you wish to begin from, and follow the instructions. <br> </p>

	<!-- Remeber how you formatted the links in previous lab-->
	<ul>
		<li><a href="https://www.learn-php.org/en/Hello%2C_World%21" target="_blank">Hello World!</a></li>
		<li><a href="https://www.learn-php.org/en/Variables_and_Types" target="_blank"> Variables</a></li>
		<li><a href="https://www.learn-php.org/en/For_loops" target="_blank"> For Loops</a></li>
		<li><a href="https://www.learn-php.org/en/Functions" target="_blank"> Functions</a></li>
		<li><a href="https://www.learn-php.org/en/While_loops" target="_blank"> While loops</a></li>
	</ul>

	<!-- Change to bold, font to Arial and text size to 120% and Center the text-->
	<p> Good Luck!</p>
	<button onclick="history.go(-1);">Back </button>
</body>

</html>