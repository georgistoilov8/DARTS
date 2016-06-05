<?php

    if (isset($_POST['submit'])) {
        $_SESSION['gameScore'] = $_POST['scoreSelect'];
        $_SESSION['legScore'] = $_POST['legSelect'];
        $_SESSION['setScore'] = $_POST['setSelect'];
        header("refresh:0;url=http://localhost/scoreboard.php", true);
    }
    $servername = "localhost";
	$username1 = "root";
	$password1 = "";
	$dbname = "registrations";
	$newURL = "http://localhost/home.php";
	// Create connection
	$conn = new mysqli($servername, $username1, $password1, $dbname);

	// Check connection
	if ($conn->connect_error) {
		die("Connection failed: " . $conn->connect_error);
	}

	$user_name = $user_nameErr = $pass_word = $pass_Err = "";
	if (empty($_POST["lg_username_2"])) {
       //$user_nameErr = "Username is required";
     } else {
       $user_name = test_input($_POST["lg_username_2"]);
       if (!preg_match("/^[a-zA-Z0-9_]*$/", $user_name)) {
         $user_nameErr = "Username can include only letters, numbers and underscore! Why you tru to hack us?";
         $user_name = "";
       }
     }

     if(empty($_POST["lg_password_2"])){
       //$pass_Err = "Password is required";
     } else {
       $pass_word = test_input($_POST["lg_password_2"]);
       if(!preg_match("/^[a-zA-Z0-9]*$/", $pass_word)){
         $pass_Err = "Password can include only letters and numbers.";
         $pass_word = "";
       }
     }

     if(isset($_POST['lg_username_2']) && !empty($_POST['lg_username_2']) AND isset($_POST['lg_password_2']) && !empty($_POST['lg_password_2'])){
		if($user_name != "" && $pass_word != ""){
			$username = mysqli_escape_string($conn, $_POST['lg_username_2']);
			$password = mysqli_escape_string($conn, md5($_POST['lg_password_2']));

			$search = mysqli_query($conn, "SELECT username, password, active FROM Users WHERE username='".$username."' AND password='".$password."' AND active='1'") or die(mysql_error());
			$match  = mysqli_num_rows($search);
			if($match > 0){
				//echo '<label style="position: absolute; top: 50%; left: 50%; transform: translateX(-50%) translateY(-50%);" class="score">Login complete. Welcome to Darts Pro 2016</label>';
				echo $msg = 'Ready';
				$_SESSION['loggedin_2'] = true;
	    		$_SESSION['username_2'] = $username;
	    		//header("refresh:2;url=".$newURL, true);
				header('Location: http://localhost/gamemode.php', true);
				die();
				// Set cookie / Start Session / Start Download etc...
			}else{
				echo $msg = 'Login Failed! Please make sure that you enter the correct details and that you have activated your account.';
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

<div class="divform">
	<div class="col-md-push-3 col-md-6 col-xs-12" style="text-align:center;">
		<form method="POST">
			<div style="text-align:cetner; position: relative; margin-top:6%; margin-left:10%; margin-right:25%">
				<label class="Plate">
					<label>  Main Score</label>
					<select name="scoreSelect">
			  			<option value="301">301</option>
			  			<option value="501">501</option>
			  			<option value="701">701</option>
			  			<option value="1001">1001</option>
					</select>
				</label>
			</div>
			<div style="text-align:cetner; position: relative; margin-top:6%; margin-left:10%; margin-right:25%">
				<label class="Plate">
					<label>Legs Format</label>
					<select name="legSelect">
			  			<option value="2">2 of 3</option>
			  			<option value="3">3 of 5</option>
			  			<option value="4">4 of 7</option>
			  			<option value="5">5 of 9</option>
					</select>
				</label>
			</div>
			<div style="text-align:cetner; position: relative; margin-top:6%; margin-left:10%; margin-right:25%">
				<label class="Plate">
					<label>Sets Format</label>
					<select name="setSelect">
			  			<option value="2">2 of 3</option>
			  			<option value="3">3 of 5</option>
			  			<option value="4">4 of 7</option>
			  			<option value="5">5 of 9</option>
					</select>
				</label>
			</div>
			<div style="text-align:cetner; margin-top:6%; margin-left:10%; margin-right:25%">
				<button id="submit" name ="submit" class="btn btn-primary red">Start Game</a><br>
			</div>
		</form>
	</div>


	<div class="col-md-pull-6 col-md-3 col-xs-6" style="text-align:center;">
		<div class="score">Player 1 is ready</div>
	</div>

	<div class="col-md-3 col-xs-6" style="text-align:center;">
		<div class="score">Player 2</div>
		<div class="login-form-1">
		<form id="login-form" class="text-left" method="post" >
			<div class="login-form-main-message"></div>
			<div class="main-login-form">
				<div class="login-group">
					<div class="form-group">
						<label for="lg_username_2" class="sr-only">Username</label>
						<input type="text" class="form-control" id="lg_username_2" name="lg_username_2" placeholder="username">
					</div>
					<div class="form-group">
						<label for="lg_password_2" class="sr-only">Password</label>
						<input type="password" class="form-control" id="lg_password_2" name="lg_password_2" placeholder="password">
					</div>
					<button type="submit" class="login-button"><i class="fa fa-chevron-right"></i></button>
				</div>
			</div>
		</form>
		</div>
	</div>
</div>

<input type="hidden" value="0" />
