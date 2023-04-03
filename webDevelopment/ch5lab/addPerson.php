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
        <title>Chapter 5 Lab: Manage Person</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="./w3.css">
    </head>
    
    <body>
        <header>
            <h1 class="w3-blue-gray w3-center">Add Person</h1>
        </header>
        <?php include("./view/nav.php"); ?>
        
        <main>
            <p>Use this page to add a person to the database.</p>
                <?php if (!empty($errorMessage)) { ?>
                    <div class="w3-panel w3-pale-red">
                        <h3>Error</h3>
                        <?php echo $errorMessage; ?>
                    </div>
                <?php } ?>
            
                <form class="w3-container w3-margin" action="." method="post" id="addPersonForm">
                    <input type="hidden" name="action" value="addPerson">
                    <input class="w3-input w3-border w3-round" type="text" placeholder="First Name" name="firstName" value="<?php echo htmlspecialchars($firstName); ?>" required autofocus>
                    <br>
                    <input class="w3-input w3-border w3-round" type="text" placeholder="Last Name" name="lastName" value="<?php echo htmlspecialchars($lastName); ?>" required>
                    <br>
                    <input class="w3-input w3-border w3-round" type="email" placeholder="Email" name="email" value="<?php echo htmlspecialchars($email); ?>">
                    <br>
                    <input class="w3-input w3-border w3-round" type="phone" placeholder="Phone (XXX-XXX-XXXX)" name="phone" value="<?php echo htmlspecialchars($phone); ?>">
                    <br>
                
                    <div class="w3-center">
                        <input class="w3-btn w3-blue-gray" type="submit" value="Add">
                    </div>
                </form>
        </main>
            
        <?php include("./view/footer.php"); ?>
    </body>
</html>