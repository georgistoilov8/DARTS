<?php
	$password = $passwordConfirm = "";
	$passErr = $passConfErr = $passNotConfErr = $msg = "";
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

	if(isset($_POST['email']) && !empty($_POST['email']) AND isset($_POST['name']) && !empty($_POST['name'])){
		$email = mysqli_escape_string($conn, $_POST['email']);
		$name = mysqli_escape_string($conn, $_POST['name']);

		$search = mysqli_query($conn, "SELECT email, name, active FROM Users WHERE email='".$email."' AND name='".$name."' AND active='1'") or die(mysql_error());
		$match  = mysqli_num_rows($search);
		
		if($match > 0){
			if(empty($_POST["pass"])){
		       $passErr = "Password is required";
		     } else {
		       $password = test_input($_POST["pass"]);
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

		     if(empty($_POST["conf_pass"])){
		       $passConfErr = "Confirm Password is required";
		     } else {
		       $passwordConfirm = test_input($_POST["conf_pass"]);
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

		     if(!empty($_POST["pass"]) && !empty($_POST["conf_pass"])){
		       $p1 = test_input($_POST["pass"]);
		       $p2 = test_input($_POST["conf_pass"]);
		       if(preg_match("/^[a-zA-Z0-9]*$/", $p1) && preg_match("/^[a-zA-Z0-9]*$/", $p2)){
		         if($p1 != $p2){
		           $passNotConfErr = "Password and Confirmed Password are not same.";
		           $password = "";
		           $passwordConfirm = "";
		         }
		       }
		     }

		    if(isset($_POST['submit'])){
		    	if($name != "" and $email != "" and $password != "" and $passwordConfirm != ""){
		    		mysqli_query($conn, "UPDATE Users SET password=md5($password) WHERE email='".$email."' AND email='".$email."' AND name='".$name."'");
		    		echo $msg = 'Successfull change';
		    		$passErr = $passConfErr = $passNotConfErr = "";
		    		$password = $email = $name = $passwordConfirm="";
		    	}
		    }
			// Set cookie / Start Session / Start Download etc...
		}else{
			$msg = 'There\'s no user with this email and this name registrated.';
		}
	}

	function test_input($data) {
	    $data = trim($data);
	    $data = stripslashes($data);
	    $data = htmlspecialchars($data);
	    return $data;
	}
	
?>
<script src="http://thecodeplayer.com/uploads/js/jquery-1.9.1.min.js" type="text/javascript"></script>
<script src="http://thecodeplayer.com/uploads/js/jquery.easing.min.js" type="text/javascript"></script>
<form id="msform" method="post" style="position: absolute; top: 37%; left: 50%; transform: translateX(-50%) translateY(-50%);" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]);?>">
	<ul id="progressbar">
		<li class="active">Account Setup</li>
		<li>Social Profiles</li>
		<li>Personal Details</li>
	</ul>

	<fieldset>
		<h2 class="fs-title">Forgot Password</h2>
		<h3 class="fs-subtitle">When you fill in your registered email address, you will be instructed on how to reset your password.</h3>
		<input type="text" name="email" id="email" placeholder="Email" />
		<input type="button" name="next" class="next action-button" value="Next" />
	</fieldset>
	<fieldset>
		<h2 class="fs-title">Forgot Password</h2>
		<h3 class="fs-subtitle">When you fill in your registered name, you will be instructed on how to reset your password.</h3>
		<input type="text" name="name" id="name" placeholder="Name" />
		<input type="button" name="previous" class="previous action-button" value="Previous" />
		<input type="button" name="next" class="next action-button" value="Next" />
	</fieldset>
	<fieldset>
		<h2 class="fs-title">Forgot Passowrd</h2>
		<h3 class="fs-subtitle">Please insert your new password</h3>
		<input type="password" name="pass" id="pass" placeholder="Password" />
		<input type="password" id="conf_pass" name="conf_pass" placeholder="New Password" />
		<input type="button" name="previous" class="previous action-button" value="Previous" />
		<button type="submit" name="submit" id="submit" onclick="" class="submit action-button" value="Submit"><i>Submit</i></button>
	</fieldset>
</form>

	<div style="margin-top: 400px;text-align: center"></div>
	<div style="color:red;font-size:15px; text-align: center;"><?php echo $msg;?></div>
    <div style="color:red;font-size:15px; text-align: center;"><?php echo $passErr;?></div>
    <div style="color:red;font-size:15px; text-align: center;"><?php echo $passConfErr;?></div>
    <div style="color:red;font-size:15px; text-align: center;"><?php echo $passNotConfErr;?></div>

<script>
//jQuery time
var current_fs, next_fs, previous_fs; //fieldsets
var left, opacity, scale; //fieldset properties which we will animate
var animating; //flag to prevent quick multi-click glitches

$(".next").click(function(){
	if(animating) return false;
	animating = true;
	
	current_fs = $(this).parent();
	next_fs = $(this).parent().next();
	
	//activate next step on progressbar using the index of next_fs
	$("#progressbar li").eq($("fieldset").index(next_fs)).addClass("active");
	
	//show the next fieldset
	next_fs.show(); 
	//hide the current fieldset with style
	current_fs.animate({opacity: 0}, {
		step: function(now, mx) {
			//as the opacity of current_fs reduces to 0 - stored in "now"
			//1. scale current_fs down to 80%
			scale = 1 - (1 - now) * 0.2;
			//2. bring next_fs from the right(50%)
			left = (now * 50)+"%";
			//3. increase opacity of next_fs to 1 as it moves in
			opacity = 1 - now;
			current_fs.css({'transform': 'scale('+scale+')'});
			next_fs.css({'left': left, 'opacity': opacity});
		}, 
		duration: 800, 
		complete: function(){
			current_fs.hide();
			animating = false;
		}, 
		//this comes from the custom easing plugin
		easing: 'easeInOutBack'
	});
});

$(".previous").click(function(){
	if(animating) return false;
	animating = true;
	
	current_fs = $(this).parent();
	previous_fs = $(this).parent().prev();
	
	//de-activate current step on progressbar
	$("#progressbar li").eq($("fieldset").index(current_fs)).removeClass("active");
	
	//show the previous fieldset
	previous_fs.show(); 
	//hide the current fieldset with style
	current_fs.animate({opacity: 0}, {
		step: function(now, mx) {
			//as the opacity of current_fs reduces to 0 - stored in "now"
			//1. scale previous_fs from 80% to 100%
			scale = 0.8 + (1 - now) * 0.2;
			//2. take current_fs to the right(50%) - from 0%
			left = ((1-now) * 50)+"%";
			//3. increase opacity of previous_fs to 1 as it moves in
			opacity = 1 - now;
			current_fs.css({'left': left});
			previous_fs.css({'transform': 'scale('+scale+')', 'opacity': opacity});
		}, 
		duration: 800, 
		complete: function(){
			current_fs.hide();
			animating = false;
		}, 
		//this comes from the custom easing plugin
		easing: 'easeInOutBack'
	});
});


</script>

