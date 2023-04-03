<?php
    // get input for action variable from POST array
//    $username = filter_input(INPUT_POST, 'action');
//    $password = filter_input(INPUT_POST, 'action');
            
//    if ($action == NULL) {
//        // if action is NULL, check GET array
//        $action = filter_input(INPUT_GET, 'action');
//        // if action is NULL, set action to view_games
//        if ($action == NULL) {
//            $action = 'authenticate_user';
//        } // end if
//    } // end if
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>Game Web App</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <link rel="stylesheet" href="w3.css">
    </head>
    
    <body>
        <main>
            <h1 class="w3-red w3-center">Games</h1>
            <?php include("view/nav.php"); ?>
            
            <div class="w3-card-2 w3-margin">
                <header class="w3-container w3-dark-gray w3-center">
                    <h2>Administrator Login</h2>
                </header>
                
                <?php if (!empty($errorMessage)) { ?>
                <div class="w3-panel w3-pale-red">
                    <?php echo $errorMessage; ?>
                </div>
                <?php } ?>
                
                <div class="w3-container">
                    <form action="./manage.php" method="post" autocomplete="off">
                        <input type="hidden" name="action" value="login">
                        <input type="text" name="username" class="w3-input w3-round w3-border w3-margin-top" placeholder="Username" required autofocus>

                        <input type="text" name="password" class="w3-input w3-border w3-round w3-margin-top" placeholder="Password" required>
                        <input class="w3-btn w3-dark-gray w3-centered w3-margin-top" type="submit" value="Log In">
                    </form>
                </div>
            </div>
        </main>
            
        <?php include("view/footer.php"); ?>
    </body>
</html>