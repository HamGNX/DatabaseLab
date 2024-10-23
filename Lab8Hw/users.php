<html>
<?php error_reporting(~E_NOTICE); ?>
<!-- Link to the style sheet "default1.css"-->
<link rel="stylesheet" href="default1.css">

<!-- Add the given image "back.jpg" as illustrated (no repeat and cover the page) -->
<body style="background: url('back.jpg') no-repeat center center fixed; background-size: cover;">

	<!-- php file begin -->
    <?php
    session_start(); // Start the session to manage login and time tracking
    
    // Assign the variables for username and password
    $username = $_POST['username'];
    $password = $_POST['passwd'];
    $confirm_password = $_POST['cpasswd'];
    
    // Check if username is 'Admin' and password is '1234', and passwords match
    if ($username == 'Admin' && $password == '1234' && $confirm_password == '1234') {
        $_SESSION["username"] = $username; // Store the username in session if valid
    } else {
        echo "<h1>You do not have access to this page!</h1>";

        // Check if the session started or not; if not, set the start time
        if (!isset($_SESSION['start_time'])) {
            $_SESSION['start_time'] = time(); // Record the session start time
        }

        // Calculate the elapsed time in seconds
        $elapsed_time = time() - $_SESSION['start_time'];

        // Display message based on elapsed time
        echo "<p>You will be given the redirecting button after ", 30 - $elapsed_time, " seconds </p><br>";

        // After 30 seconds, display the back button
        if ($elapsed_time > 30) {
            $txt = "history.go(-1);";
            echo "<button onclick='$txt'>Back </button>";
            
            // Unset and destroy session after 30 seconds
            session_unset();
            session_destroy();
        } else {
            header("Refresh:1"); // Refresh the page every second
        }
        
        exit; // Stop further processing the page if access is denied
    }
    ?>
    <!-- php file end -->

	<!-- the heading is given as "Welcome Mr./Mrs./Ms. User Name", change the font to Arial, size of font to 200%, make the text appear in center-->
	<h1 style="font-family: Arial; font-size: 200%; text-align: center;">
        Welcome <?php echo $_POST["title"], " ", $_POST["firstname"], " ", $_POST["lastname"], "!!!"; ?><br>
    </h1>

	<!-- add the image "avatar.png", height to 240 pixels-->
	<img src="avatar.png" height="240px">

	<!-- change the font to Arial, size of font to 170%-->
	<h3 style="font-family: Arial; font-size: 170%;"> This is your profile </h3>

	<!-- change the font to Arial-->
	<p style="font-family: Arial;">
    <?php
    // Displaying the form data
    echo "Name: ", $_POST["title"], " ", $_POST["firstname"], " ", $_POST["lastname"], "<br>";
    echo "User Group: ", $_POST["usergroup"], "<br>";
    echo "Email Address: ", $_POST["email"], "<br>";

    $Temp;
    if ($_POST["title"] == "Mr."){
        echo "Gender: Male", "<br>";
    }
    else if ($_POST["title"] == "Mrs." || $_POST["title"] == "Ms."){
        echo "Gender: Female",  "<br>";
    }

    // Calculate age
    $bday = new DateTime($_POST['birthdate']);
    $today = new DateTime('today');
    $age = $today->diff($bday)->y;
    echo "Age in years: $age<br>";

    // Set default time zone
    date_default_timezone_set("Asia/Bangkok");
	echo "Login time (local): ", date("g:i:s A"), " on ", date("Y-m-d"), "<br>";
    ?>
	</p>

	<!-- change font to Arial, bold and font size to 150%-->
	<p style="font-family: Arial; font-weight: bold; font-size: 150%;"> Welcome to the CSS326 system <br></p>

	<!-- Informative paragraph -->
	<p style="font-family: Arial;">
		Whether you are an experienced programmer or not, this website is intended for everyone who wishes to learn Database programming.
		There is no need to download anything - just click on the chapter you wish to begin from, and follow the instructions. <br>
	</p>

	<!-- Centered orange box for the links -->
	<div class="link-box">
		<ul>
			<li><a href="https://www.learn-php.org/en/Hello%2C_World%21" target="_blank">Hello World!</a></li>
			<li><a href="https://www.learn-php.org/en/Variables_and_Types" target="_blank"> Variables</a></li>
			<li><a href="https://www.learn-php.org/en/For_loops" target="_blank"> For Loops</a></li>
			<li><a href="https://www.learn-php.org/en/Functions" target="_blank"> Functions</a></li>
			<li><a href="https://www.learn-php.org/en/While_loops" target="_blank"> While loops</a></li>
		</ul>
	</div>

	<!-- Change to bold, font to Arial and text size to 120% and Center the text-->
	<p style="font-weight: bold; font-family: Arial; font-size: 120%; text-align: center;">
        Good Luck!
    </p>
	
	<!-- Back button -->
	<button onclick="history.go(-1);">Back </button>
</body>
</html>