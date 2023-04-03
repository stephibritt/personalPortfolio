<?php
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Chapter 4 Lab: Manage Person</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <header>
            <h1 class="w3-blue-gray w3-center">Manage Person</h1>
        </header>
        <?php include("nav.php"); ?>
        
        <main>
            
            <form class="w3-container" action="whenIsEaster.php" method="post">
                
                <p>Choose an operation to manage the person table of the DPJS Database.</p>
                
                <?php if (!empty($errorMessage)) { ?>
                    <div class="w3-panel w3-pale-red">
                        <h3>Error</h3>
                        <?php echo $errorMessage; ?>
                    </div>
                <?php } ?>
                    
                <div class="w3-center">
                    <a class="w3-btn w3-blue-gray" href="addPersonForm.php">Add Person</a>
                    <a class="w3-btn w3-blue-gray" href="viewPerson.php">View Person</a>
                </div>
            </form>
        </main>
            
        <?php include("footer.php"); ?>
    </body>
</html>