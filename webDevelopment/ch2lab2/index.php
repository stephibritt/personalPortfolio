<?php
    if (!isset($year)) {
        $year = "";
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
        <title>Chapter 2 Lab 2: When is Easter?</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <main>
            <form class="w3-container w3-margin" action="whenIsEaster.php" method="post">
                <h1 class="w3-blue-gray w3-center">When is Easter?</h1>
                
                <p>Enter a year to calculate when Easter  falls for that year.</p>
                
                <?php if (!empty($errorMessage)) { ?>
                    <div class="w3-panel w3-pale-red">
                        <h3>Error</h3>
                        <?php echo $errorMessage; ?>
                    </div>
                <?php } ?>
                    
                <div class="w3-left-align">
                    <input class="w3-input" type="text" name="year" value="<?php echo htmlspecialchars($year); ?>">
                    <label>Year</label><br>
                </div>
                <div class="w3-center">
                    <button class="w3-btn w3-blue-gray">Submit</button>
                </div>
                
            </form>
        </main>
    </body>
</html>