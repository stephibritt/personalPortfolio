<?php
    // receive data from POST array
    $year = filter_input(INPUT_POST, 'year', FILTER_VALIDATE_INT);
    
    // set error message to an empty string
    $errorMessage = "";
    
    // validate the data
    if ($year === FALSE) {
        $errorMessage = "Year must be a valid number.";
    } else if ($year < 1) {
        $errorMessage = "Year must be greater than zero.";
    } // end if
    
    //if an error message exist, return to index.php
    if ($errorMessage != "") {
        include("index.php");
        exit();
    } // end if
	
    // Computus algorithm
    $a = $year % 19;
    $b = floor($year / 100);
    $c = $year % 100;
    $d = floor($b / 4);
    $e = $b % 4;
    $f = floor(($b + 8) / 25);
    $g = floor(($b - $f + 1) / 3);
    $h = (19 * $a + $b - $d - $g + 15) % 30;
    $i = floor($c / 4);
    $k = $c % 4;
    $l = (32 + 2 * $e + 2 * $i - $h - $k) % 7;
    $m = floor(($a + 11 * $h + 22 * $l) / 451);
    $month = floor(($h + $l - 7 * $m + 114) / 31);
    $day = 1 + (($h + $l - 7 * $m + 114) % 31);
    
    //format output
    
    if ($month == 3) {
        $output = "In $year, Easter falls on <strong>March $day</strong>.";
    } else if ($month == 4) {
        $output = "In $year, Easter falls on <strong>April $day</strong>.";
    } // end if
?>

<!DOCTYPE html>
<!-- 
Edited by: Stephen Britt
File Name: whenIsEaster.php
Date: 09/08/2022
-->
<html lang="en">
    <head>
        <title>Chapter 2 Lab 1: When is Easter?</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <main class="w3-container w3-margin">
            <h1 class="w3-blue-gray w3-center">When is Easter?</h1>
            
            <span><?php echo $output; ?></span><br><br>
            
            <div class="w3-center">
                <a href="index.php" class="w3-btn w3-blue-gray">Click here to calculate another year.</a>
            </div>
        </main>
    </body>
</html>