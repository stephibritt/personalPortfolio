<?php
    if (!isset($firstName)) {
        $firstName = "";
    } // end if
    
    if (!isset($lastName)) {
        $lastName = "";
    } // end if
    
    if (!isset($email)) {
        $email = "";
    } // end if
    
    if (!isset($phone)) {
        $phone = "";
    } // end if
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Chapter 4 Lab: Manage Person</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=0.80">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <header>
            <h1 class="w3-blue-gray w3-center">Add Person</h1>
        </header>
        <?php include("nav.php"); ?>
        
        <main>
            <form class="w3-container w3-margin" action="addPerson.php" method="post">
                
                
                <p>Use this page to add a person to the database.</p>
                
                <?php if (!empty($errorMessage)) { ?>
                    <div class="w3-panel w3-pale-red">
                        <h3>Error</h3>
                        <?php echo $errorMessage; ?>
                    </div>
                <?php } ?>
                    
                <div class="w3-left-align">
                    <input class="w3-input w3-border w3-round" type="text" placeholder="First Name" name="firstName" value="<?php echo htmlspecialchars($firstName); ?>" required autofocus>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Last Name" name="lastName" value="<?php echo htmlspecialchars($lastName); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="email" placeholder="Email" name="email" value="<?php echo htmlspecialchars($email); ?>">
                    <br>
                    <input class="w3-input w3-border w3-round" type="phone" placeholder="Phone (XXX-XXX-XXXX)" name="phone" value="<?php echo htmlspecialchars($phone); ?>">
                    <br>
                </div>
                
                <div class="w3-center">
                    <button class="w3-btn w3-blue-gray">Add Person</button>
                </div>
            </form>
        </main>
            
        <?php include("footer.php"); ?>
    </body>
</html>