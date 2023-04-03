<?php
    // receive data from POST array
    $startYear = filter_input(INPUT_POST, 'startYear', FILTER_VALIDATE_INT);
    $endYear = filter_input(INPUT_POST, 'endYear', FILTER_VALIDATE_INT);
    
    // set error message to an empty string
    $startYearErrorMessage = "";
    $endYearErrorMessage = "";
    
    // validate the data
    if ($startYear === FALSE) {
        $startYearErrorMessage = "A start year must be a valid number.";
    } else if ($startYear < 1) {
        $startYearErrorMessage = "A start year must be greater than zero.";
    } // end if
    
    if ($endYear === FALSE) {
        $endYearErrorMessage = "An end year must be a valid number.";
    } else if ($startYear < 1) {
        $endYearErrorMessage = "An end year must be greater than zero.";
    } else if ($endYear < $startYear) {
        $endYearErrorMessage = "An end year must be greater than or equal to $startYear.";
    } // end if
    
    //if an error message exist, return to index.php
    if ($startYearErrorMessage != "" || $endYearErrorMessage != "") {
        include("index.php");
        exit();
    } // end if
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Midterm Exam</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <h1 class="w3-blue-gray w3-center">Easter List Generator</h1>
        <main class="w3-container w3-margin">
            <p> Easters between years <?php echo $startYear; ?> and <?php echo $endYear; ?>.</p>
            
            <table class="w3-table-all w3-centered">
                <tr class="w3-blue">
                  <th>Count</th>
                  <th>Year</th>
                  <th>Easter Date</th>
                </tr>
                
                <?php 
                $count = 1;
                
                for ($year = $startYear; $year <= $endYear; $year++) {
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
                        $output = "March $day";
                    } else if ($month == 4) {
                        $output = "April $day";
                    } // end if ?>
                
                    <tr>
                        <td><?php echo $count; ?></td>
                        <td><?php echo $year; ?></td>
                        <td><?php echo $output; ?></td>
                    </tr>
                    
                <?php 
                    $count++;
                
                } // end for?>
            </table>
            <br>
            
            <div class="w3-center">
                <a href="index.php" class="w3-btn w3-blue-gray">Click here to calculate another year.</a>
            </div>
        </main>
    </body>
</html>