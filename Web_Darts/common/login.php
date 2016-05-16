<?php
	$servername = "localhost";
	$username1 = "root";
	$password1 = "";
	$dbname = "registrations";
	$newURL = "http://77.70.92.71/htdocs/home.php";
	// Create connection
	$conn = new mysqli($servername, $username1, $password1, $dbname);

	// Check connection
	if ($conn->connect_error) {
		die("Connection failed: " . $conn->connect_error);
	}

	$user_name = $user_nameErr = $pass_word = $pass_Err = "";
	if (empty($_POST["lg_username"])) {
       //$user_nameErr = "Username is required";
     } else {
       $user_name = test_input($_POST["lg_username"]);
       if (!preg_match("/^[a-zA-Z0-9_]*$/", $user_name)) {
         $user_nameErr = "Username can include only letters, numbers and underscore! Why you tru to hack us?";
         $user_name = "";
       }
     }

     if(empty($_POST["lg_password"])){
       //$pass_Err = "Password is required";
     } else {
       $pass_word = test_input($_POST["lg_password"]);
       if(!preg_match("/^[a-zA-Z0-9]*$/", $pass_word)){
         $pass_Err = "Password can include only letters and numbers.";
         $pass_word = "";
       }
     }

     if(isset($_POST['lg_username']) && !empty($_POST['lg_username']) AND isset($_POST['lg_password']) && !empty($_POST['lg_password'])){
		if($user_name != "" && $pass_word != ""){
			$username = mysqli_escape_string($conn, $_POST['lg_username']);
			$password = mysqli_escape_string($conn, md5($_POST['lg_password']));

			$search = mysqli_query($conn, "SELECT username, password, active FROM Users WHERE username='".$username."' AND password='".$password."' AND active='1'") or die(mysql_error());
			$match  = mysqli_num_rows($search);
			if($match > 0){
				echo '<label style="position: absolute; top: 50%; left: 50%; transform: translateX(-50%) translateY(-50%);" class="score">Login complete. Welcome to Darts Pro 2016</label>';
				$_SESSION['loggedin'] = true;
	    		$_SESSION['username'] = $username;
	    		header("refresh:2;url=".$newURL, true);
				//header('Location: '.$newURL, true);
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
<div class="text-center" style="position: absolute; top: 44%; left: 50%; transform: translateX(-50%) translateY(-50%);">
	<div class="logo">login</div>
	<!-- Main Form -->
	<div class="login-form-1">
		<form id="login-form" class="text-left" method="post" >
			<div class="login-form-main-message"></div>
			<div class="main-login-form">
				<div class="login-group">
					<div class="form-group">
						<label for="lg_username" class="sr-only">Username</label>
						<input type="text" class="form-control" id="lg_username" name="lg_username" placeholder="username">
					</div>
					<div class="form-group">
						<label for="lg_password" class="sr-only">Password</label>
						<input type="password" class="form-control" id="lg_password" name="lg_password" placeholder="password">
					</div>
					<div class="form-group login-group-checkbox">
						<input type="checkbox" id="lg_remember" name="lg_remember">
						<label for="lg_remember">remember</label>
					</div>
				</div>
				<button type="submit" class="login-button"><i class="fa fa-chevron-right"></i></button>
			</div>
			<div class="etc-login-form">
				<p>forgot your password? <a href="resetpassword.php" class="terms">click here</a></p>
				<p>new user? <a href="register.php" class="terms">create new account</a></p>
			</div>
			<div style="color:red;font-size:15px"><?php echo $user_nameErr;?></div>
		    <div style="color:red;font-size:15px"><?php echo $pass_Err;?></div>
		    <div style="color:red;font-size:15px"><?php echo $msg;?></div>
		</form>
	</div>
	<!-- end:Main Form -->
</div>