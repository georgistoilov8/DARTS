<?php
  // define variables and set to empty values
  $nameErr = $emailErr = $genderErr = $passErr = $passConfErr = $passNotConfErr = $usernameErr = $agreeErr = "";
  $name = $email = $gender = $passwordConfirm = $password = $username = $agree = "";

  if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $servername = "localhost";
    $username1 = "root";
    $password1 = "";
    $dbname = "registrations";
    echo "Trying to connect";
    echo "autism";
   // echo mysqli_connect($servername, $username1, $password1, $dbname);
    $conn = new mysqli($servername, $username1, $password1, $dbname);

    if (!$conn) {
        echo "Error: Unable to connect to MySQL." . PHP_EOL;
        echo "Debugging errno: " . mysqli_connect_errno() . PHP_EOL;
        echo "Debugging error: " . mysqli_connect_error() . PHP_EOL;
    }

    echo "<br>";
    echo "Must be connected";

    if ($conn->connect_error) {
        echo "DIE";
        die("Connection failed: " . $conn->connect_error);
    }


     if (empty($_POST["reg_fullname"])) {
       $nameErr = "Name is required";
     } else {
       $name = test_input($_POST["reg_fullname"]);
       // check if name only contains letters and whitespace
       if (!preg_match("/^[a-zA-Z ]*$/",$name)) {
         $nameErr = "Name can include only letters and white spaces.";
         $name = "";
       }
     }

     if(empty($_POST["reg_password"])){
       $passErr = "Password is required";
     } else {
       $password = test_input($_POST["reg_password"]);
       if(!preg_match("/^[a-zA-Z0-9]*$/", $password)){
         $passErr = "Password can include only letters and numbers.";
         $password = "";
       }
       if(strlen($password) < 4){
         $passErr = "Too short password.";
         $password = "";
       }else if(strlen($password) > 32){
         $passErr = "Too long password.";
         $password = "";
       }
     }

     if(empty($_POST["reg_password_confirm"])){
       $passConfErr = "Confirm Password is required";
     } else {
       $passwordConfirm = test_input($_POST["reg_password_confirm"]);
       if(!preg_match("/^[a-zA-Z0-9]*$/", $passwordConfirm)){
         $passErr = "Confirm Password can include only letters and numbers.";
         $passwordConfirm = "";
       }
       if(strlen($passwordConfirm) < 4){
         $passConfErr = "Too short password.";
         $passwordConfirm = "";
       }else if(strlen($passwordConfirm) > 32){
         $passConfErr = "Too long password.";
         $passwordConfirm = "";
       }
     }

     if(!empty($_POST["reg_password"]) && !empty($_POST["reg_password_confirm"])){
       $p1 = test_input($_POST["reg_password"]);
       $p2 = test_input($_POST["reg_password_confirm"]);
       if(preg_match("/^[a-zA-Z0-9]*$/", $p1) && preg_match("/^[a-zA-Z0-9]*$/", $p2)){
         if($p1 != $p2){
           $passNotConfErr = "Password and Confirmed Password are not same.";
           $password = "";
           $passwordConfirm = "";
         }
       }
     }


     if (empty($_POST["reg_email"])) {
       $emailErr = "Email is required";
     } else {
       $email = test_input($_POST["reg_email"]);
       $search_email = mysqli_query($conn, "SELECT email FROM Users WHERE email='".$email."'");
       if ($conn->connect_error) {
           die("Connection failed: " . $conn->connect_error);
       }
       $match_email  = mysqli_num_rows($search_email);
       // check if e-mail address is well-formed
       if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
         $emailErr = "Invalid email format";
         $email = "";
       }
       if ($match_email > 0){
         $emailErr = "This e-mail is already used. Try with different.";
         $email = "";
       }
     }

     if (empty($_POST["reg_gender"])) {
       $genderErr = "Gender is required";
       $gender = "";
     } else {
       $gender = test_input($_POST["reg_gender"]);
     }

     if (empty($_POST["reg_agree"])) {
       $agreeErr = "You need to agree our terms.";
       $agree = "";
     } else {
       $agree = test_input($_POST["reg_agree"]);
     }


     if (empty($_POST["reg_username"])) {
       $usernameErr = "Username is required";
     } else {
       $username = test_input($_POST["reg_username"]);
       $search_username = mysqli_query($conn, "SELECT username FROM Users WHERE username='".$username."'");
       if ($conn->connect_error) {
           die("Connection failed: " . $conn->connect_error);
       }
       $match_username  = mysqli_num_rows($search_username);
       if (!preg_match("/^[a-zA-Z0-9_]*$/", $username)) {
         $usernameErr = "Username can include only letters, numbers and underscore";
         $username = "";
       }

       if ($match_username > 0){
         $usernameErr = "This username is already used. Please try with different.";
         $username = "";
       }
     }
  }

  function test_input($data) {
     $data = trim($data);
     $data = stripslashes($data);
     $data = htmlspecialchars($data);
     return $data;
  }
?>

<div class="text-center" style="position: absolute; top: 42%; left: 50%; transform: translateX(-50%) translateY(-50%);">
	<div class="logo">register</div>
	<!-- Main Form -->
	<div class="login-form-1">
		<form id="register-form" class="text-left" method="post" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
			<div class="login-form-main-message"></div>
			<div class="main-login-form">
				<div class="login-group">

					<div class="form-group" style="position: relative">
						<label for="reg_username" class="sr-only" id="reg_username_1">Username</label>
						<input type="text" class="form-control" id="reg_username" name="reg_username" placeholder="username" required="">
            <div style="position: absolute; top: 30px; right: 280px; background-color:rgb(120, 255, 148)" class="btn btn-secondary connected text-center" data-toggle="tooltip" data-placement="left" title="Username can include only letters, symbols and underscores.">
                <strong>i</strong>
            </div>
          </div>

					<div class="form-group" style="position: relative">
						<label for="reg_password" class="sr-only">Password</label>
						<input type="password" class="form-control" id="reg_password" name="reg_password" placeholder="password" required="">
            <div style="position: absolute; top: 30px; right: 280px; background-color:rgb(120, 255, 148)" class="btn btn-secondary connected text-center" data-toggle="tooltip" data-placement="left" title="Password must have at least 4 symbols and max 32 symbols.">
                <strong>i</strong>
            </div>
					</div>

					<div class="form-group" style="position: relative">
						<label for="reg_password_confirm" class="sr-only">Password Confirm</label>
						<input type="password" class="form-control" id="reg_password_confirm" name="reg_password_confirm" placeholder="confirm password" required="">
            <div style="position: absolute; top: 35px; right: 280px; background-color:rgb(120, 255, 148); text-color:black" class="btn btn-secondary connected text-center" data-toggle="tooltip" data-placement="left" title="Confirm Password must have at least 4 symbols and max 32 symbols. Also Password and Confirmed Password must be the same.">
                <strong>i</strong>
            </div>
					</div>

					<div class="form-group" style="position: relative">
						<label for="reg_email" class="sr-only">Email</label>
						<input type="text" class="form-control" id="reg_email" name="reg_email" placeholder="email" required="">
            <div style="position: absolute; top: 40px; right: 280px; background-color:rgb(120, 255, 148); text-color:black" class="btn btn-secondary connected text-center" data-toggle="tooltip" data-placement="left" title="Valid e-mail.">
                <strong>i</strong>
            </div>
					</div>

					<div class="form-group" style="position: relative">
						<label for="reg_fullname" class="sr-only">Full Name</label>
						<input type="text" class="form-control" id="reg_fullname" name="reg_fullname" placeholder="full name" required="">
            <div id = "tooltipp"style="position: absolute; top: 40px; right: 280px; background-color:rgb(120, 255, 148); text-color:black" class="btn btn-secondary connected text-center" data-toggle="tooltip" data-placement="left" title="Name can include only letters and white spaces.">
                <strong>i</strong>
            </div>
					</div>

					<div class="form-group login-group-checkbox">
						<input type="radio" class="" name="reg_gender" id="male" value = "male" placeholder="username" required="">
						<label for="male">male</label>

						<input type="radio" class="" name="reg_gender" id="female" value = "female" placeholder="username" required="">
						<label for="female">female</label>
					</div>

					<div class="form-group login-group-checkbox">
						<input type="checkbox" class="" id="reg_agree" name="reg_agree" value = "yes" required="">
						<label for="reg_agree">i agree with <a href="terms.php" class="terms" name="terms">terms</a></label>
					</div>
				</div>
				<button type="submit" class="login-button" id="reg_button" name="reg_button" onclick=""><i class="fa fa-chevron-right"></i></button>
			</div>
			<div class="etc-login-form">
				<p>already have an account? <a href="login.php" class="terms" id="terms">login here</a></p>
			</div>
      <div style="color:red;font-size:15px"><?php echo $usernameErr;?></div>
      <div style="color:red;font-size:15px"><?php echo $emailErr;?></div>
      <div style="color:red;font-size:15px"><?php echo $nameErr;?></div>
      <div style="color:red;font-size:15px"><?php echo $passErr;?></div>
      <div style="color:red;font-size:15px"><?php echo $passConfErr;?></div>
      <div style="color:red;font-size:15px"><?php echo $passNotConfErr;?></div>
		</form>
	</div>
</div>
<script>
$(document).ready(function(){
    $('[data-toggle="tooltip"]').tooltip();
});

$("body").click(function() {
    $(".overlay").toggle(); // show/hide the overlay
});
//var height = &(window).height();
//console.log(height, "Hello, world!");$(document).on("pagecreate", function () {

</script>

<?php

$male = 0;
$female = 0;
if($gender == "male"){
  $male = 1;
}else {
  $female = 1;
}

if(isset($_POST['reg_button'])){
  if($name != "" and $email != "" and $gender != "" and $username != "" and $password != "" and $passwordConfirm != "" and $agree != ""){
    echo "<br>";
    echo "Successfull registration";
    echo "<br>";
  //  mysqli_connect("localhost", "root", "") or die(mysqli_close()); // Connect to database server(localhost) with username and password.
  //  mysql_select_db("registrations") or die(mysql_close()); // Select registrations database.
    $servername = "localhost";
    $username1 = "root";
    $password1 = "";
    $dbname = "registrations";
    // Create connection
    $conn = new mysqli($servername, $username1, $password1, $dbname);

    // Check connection
    if ($conn->connect_error) {
        die("Connection failed: " . $conn->connect_error);
    }
    echo "Connected successfully";


    $msg = 'Your account has been made, <br /> please verify it by clicking the activation link that has been send to your email.';
    $hash = md5( rand(0,1000) ); // Generate random 32 character hash and assign it to a local variable.
    //$local_password = rand(1000,5000); // Generate random number between 1000 and 5000 and assign it to a local variable.
    // Example output: 4568
      mysqli_query($conn, "INSERT INTO Users (username, password, email, name, male, female, hash) VALUES(
      '". mysqli_real_escape_string($conn, $username) ."',
      '". mysqli_real_escape_string($conn, md5($password)) ."',
      '". mysqli_real_escape_string($conn, $email) ."',
      '". mysqli_real_escape_string($conn, $name) ."',
      '". mysqli_real_escape_string($conn, $male) ."',
      '". mysqli_real_escape_string($conn, $female) ."',
      '". mysqli_real_escape_string($conn, $hash) ."') ") or die($conn->connect_error);

      $getID = mysqli_fetch_assoc(mysqli_query($conn, "SELECT id FROM Users WHERE username = '".$username."'"));
      $id = $getID['id'];

      mysqli_query($conn, "INSERT INTO Statistics (playerid) VALUES('".$id."')") or die('Connect Error: ' . $conn->connect_error);
      $to      = $email; // Send email to our user
      $subject = 'Signup | Verification'; // Give the email a subject
      $message = '

      Thanks for signing up!
      Your account has been created, you can login with the following credentials after you have activated your account by pressing the url below.

      ------------------------
      Username: '.$username.'
      Password: '.$password.'
      ------------------------

      Please click this link or copy it to the URL section of your browser to activate your account:
      http://localhost/verify.php?email=' . $email . '&hash=' . $hash . '

      '; // Our message above including the link

      $headers = 'From:georgistoilov123@gmail.com' . "\r\n"; // Set from headers
      mail($to, $subject, $message, $headers); // Send our email

      echo "<br>";
      echo "We send you a verification e-mail";
  }
}
?>
