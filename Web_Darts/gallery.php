<?php include_once "common/header.php"; ?>

<?php 
  if (isset($_SESSION['loggedin']) && $_SESSION['loggedin'] == true) {
    //echo "Welcome to the member's area, " . $_SESSION['username'] . "!";
	include_once "common/navbar_log.php";
  } else {
    //echo "Please log in first to see this page.";
	include_once "common/navbar.php";
  } 
?>

<?php include_once "common/gallery.php"; ?>

<?php include_once "common/sidebar.php"; ?>

<?php include_once "common/footer.php"; ?>
