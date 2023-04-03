<?php
    if (!isset($startYear)) {
        $startYear = "";
    } // end if
    
    if (!isset($endYear)) {
        $endYear = "";
    } // end if
?>

<!DOCTYPE html>
<!-- 
Edited by: Stephen Britt
File Name: index.php
Date: 09/08/2022
-->
<html lang="en">
    <head>
        <title>Midterm Exam</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <main>
            <h1 class="w3-blue-gray w3-center">Easter List Generator</h1>
            <form class="w3-container w3-margin" action="whenIsEaster.php" method="post">
                
                
                <p>Enter a start and end year to generate a list of Easter dates.</p>
                
                <?php if (!empty($startYearErrorMessage)) { ?>
                    <div class="w3-panel w3-pale-red">
                        <h3>Error</h3>
                        <?php echo $startYearErrorMessage; ?>
                    </div>
                <?php } ?>
                    
                <div class="w3-left-align">
                    <input class="w3-input" type="text" name="startYear" value="<?php echo htmlspecialchars($startYear); ?>">
                    <label>Start Year</label>
                </div>
                
                <?php if (!empty($endYearErrorMessage)) { ?>
                    <div class="w3-panel w3-pale-red">
                        <h3>Error</h3>
                        <?php echo $endYearErrorMessage; ?>
                    </div>
                <?php } ?>
                
                <div class="w3-left-align">
                    <input class="w3-input" type="text" name="endYear" value="<?php echo htmlspecialchars($endYear); ?>">
                    <label>End Year</label>
                </div>
                
                <div class="w3-center">
                    <button class="w3-btn w3-blue-gray">Submit</button>
                </div>
            </form>
        </main>
    </body>
</html>